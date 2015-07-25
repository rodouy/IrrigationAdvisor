using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Drawing;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace IrrigationAdvisor.Models.Utilities
{
    public static class Utils
    {
        #region Consts
        
        public static String LANGUAGE = "English";
        public static String REGION = "Uruguay";
        
        #endregion
        
        #region Enums

        public enum NotificationType
        {
            /// <summary>
            /// Users will not be notified, 
            ///     exceptions will be automatically logged
            /// </summary>
            Silent,
            /// <summary>
            /// Users will be notified an exception has occurred,
            ///     exceptions will be automatically logged
            /// </summary>
            Inform,
            /// <summary>
            /// Users will be notified an exception has occurred
            ///     and will be asked if they want the exception logged.
            /// </summary>
            Ask
        }

        public enum IrrigationUnitType
        {
            /// <summary>
            /// Irrigation type Pivot
            /// </summary>
            Pivot,
            /// <summary>
            /// Irrigation type Sprinkler
            /// </summary>
            Sprinkler,
            /// <summary>
            /// Irrigation type Drip
            /// </summary>
            Drip
        }

        public enum WaterInputType
        {
            /// <summary>
            /// 
            /// </summary>
            Rain,
            /// <summary>
            /// 
            /// </summary>
            Irrigation,
            /// <summary>
            /// 
            /// </summary>
            IrrigationByETCAcumulated,
            /// <summary>
            /// 
            /// </summary>
            IrrigationByHydricBalance,
        }

        public enum WaterOutputType
        {
            /// <summary>
            /// 
            /// </summary>
            Evapotranspiration
        }

        public enum CalculusOfPhenologicalStage
        {
            /// <summary>
            /// Use Days After Sowing for the calculus of Phenological Stage
            /// Phenological Stage, Deep of Root and Crop Coefficient depend on this calculus
            /// </summary>
            ByDaysAfterSowing,
            /// <summary>
            /// Use Growing Degree Days for the calculus of Phenological Stage
            /// Phenological Stage, Deep of Root and Crop Coefficient depend on this calculus
            /// </summary>
            ByGrowingDegreeDays,
        }

        #endregion

        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Construction
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Return the difference in days between two Dates
        /// </summary>
        /// <param name="oldDate"></param>
        /// <param name="newDate"></param>
        /// <returns></returns>
        public static int GetDaysDifference(DateTime oldDate, DateTime newDate)
        {
            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;

            // Difference in days.
            return  ts.Days;
        }

        /// <summary>
        /// Return if the Date One is Later than Date Two.
        /// NOT Compares Years.
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static bool IsBetweenDatesWithoutYear(DateTime pDateOne, DateTime pDateTwo, DateTime pDateBetween)
        {
            bool lReturn = false;
            DateTime lNewDateTime;

            if (pDateTwo >= pDateOne)
            {
                lNewDateTime = new DateTime(pDateOne.Year, pDateBetween.Month, pDateBetween.Day);
                if (pDateOne <= lNewDateTime && pDateTwo >= lNewDateTime)
                {
                    lReturn = true;
                }
            }
            else
            {
                lNewDateTime = new DateTime(pDateTwo.Year, pDateBetween.Month, pDateBetween.Day);
                if (pDateOne >= lNewDateTime && pDateTwo <= lNewDateTime)
                {
                    lReturn = true;
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Return if the Dates have the same month and day.
        /// NOT Compares Years.
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static bool IsTheSameDayWithoutYear(DateTime pDateOne, DateTime pDateTwo)
        {
            bool lReturn = false;
            bool lIsTheSameDay = false;

            if (pDateOne.Month == pDateTwo.Month && pDateOne.Day == pDateTwo.Day)
            {
                lIsTheSameDay = true;
            }

            lReturn = lIsTheSameDay;
            return lReturn;
        }

        /// <summary>
        /// Return if the Dates have the same year, month and day.
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static bool IsTheSameDay(DateTime pDateOne, DateTime pDateTwo)
        {
            bool lReturn = false ;
            if (pDateOne.Year == pDateTwo.Year && pDateOne.Month == pDateTwo.Month && pDateOne.Day == pDateTwo.Day)
            {
                lReturn = true;
            }
            return lReturn;
        }

        /// <summary>
        /// Return if the Dates have the same year, month, day and hour.
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static bool IsTheSameDayAndHour(DateTime dateOne, DateTime dateTwo)
        {
            bool lReturn = false;
            if (dateOne.Year == dateTwo.Year 
                && dateOne.Month == dateTwo.Month 
                && dateOne.Day == dateTwo.Day
                && dateOne.Hour == dateTwo.Hour)
            {
                lReturn = true;
            }
            return lReturn;
        }

        #endregion

        #region Overrides
        #endregion



    }

    /// <summary>
    /// Abstract class for logging errors to different output devices, 
    /// primarily for use in Windows Forms applications
    /// </summary>
    public abstract class LoggerImplementation
    {
        /// <summary>Logs the specified error.</summary>
        /// <param name="error">The error to log.</param>
        public abstract void LogError(string error);
    }

    /// <summary>
    /// Class to log unhandled exceptions
    /// </summary>
    public class ExceptionLogger
    {
        /// <summary>
        /// Creates a new instance of the ExceptionLogger class
        /// </summary>
        public ExceptionLogger()
        {
              Application.ThreadException +=
                  new System.Threading.ThreadExceptionEventHandler(OnThreadException);
              AppDomain.CurrentDomain.UnhandledException += 
                  new UnhandledExceptionEventHandler(OnUnhandledException);
              loggers = new List<LoggerImplementation>();
        }

        private List<LoggerImplementation> loggers;
        /// <summary>
        /// Adds a logger implementation to the list of used loggers.
        /// </summary>
        /// <param name="logger">The logger to add.</param>
        public void AddLogger(LoggerImplementation logger)
        {
            loggers.Add(logger);
        }

    private Utils.NotificationType notificationType = Utils.NotificationType.Ask;
    /// <summary>
    /// Gets or sets the type of the notification shown to the end user.
    /// </summary>
    public Utils.NotificationType NotificationType
    {
        get { return notificationType; }
        set { notificationType = value; }
    }
    
    delegate void LogExceptionDelegate(Exception e);
    private void HandleException(Exception e)
    {
        switch (notificationType)
        {
            case Utils.NotificationType.Ask:
                 if (MessageBox.Show("An unexpected error occurred - " + e.Message +
                  ". Do you wish to log the error?", "Error", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                 break;
            case Utils.NotificationType.Inform:
                  MessageBox.Show("An unexpected error occurred - " + e.Message);
                  break;
            case Utils.NotificationType.Silent:
                  break;
        }

        LogExceptionDelegate logDelegate = new LogExceptionDelegate(LogException);
        logDelegate.BeginInvoke(e, new AsyncCallback(LogCallBack), null);
    }

    // Event handler that will be called when an unhandled
    // exception is caught
    private void OnThreadException(object sender, ThreadExceptionEventArgs e)
    {
        // Log the exception to a lFile
        HandleException(e.Exception);
    }

    private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        HandleException((Exception)e.ExceptionObject);
    }

    private void LogCallBack(IAsyncResult result)
    {
        AsyncResult asyncResult = (AsyncResult)result;
        LogExceptionDelegate logDelegate = (LogExceptionDelegate)asyncResult.AsyncDelegate;
        if (!asyncResult.EndInvokeCalled)
        {
            logDelegate.EndInvoke(result);
        }
    }

    private string GetExceptionTypeStack(Exception e)
    {
        if (e.InnerException != null)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine(GetExceptionTypeStack(e.InnerException));
            message.AppendLine("   " + e.GetType().ToString());
            return (message.ToString());
        }
        else
        {
            return "   " + e.GetType().ToString();
        }
    }

    private string GetExceptionMessageStack(Exception e)
    {
        if (e.InnerException != null)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine(GetExceptionMessageStack(e.InnerException));
            message.AppendLine("   " + e.Message);
            return (message.ToString());
        }
        else
        {
            return "   " + e.Message;
        }
    }

    private string GetExceptionCallStack(Exception e)
    {
        if (e.InnerException != null)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine(GetExceptionCallStack(e.InnerException));
            message.AppendLine("--- Next Call Stack:");
            message.AppendLine(e.StackTrace);
            return (message.ToString());
        }
        else
        {
            return e.StackTrace;
        }
    }

    private static TimeSpan GetSystemUpTime()
    {
        PerformanceCounter upTime = new PerformanceCounter("System", "System Up Time");
        upTime.NextValue();
        return TimeSpan.FromSeconds(upTime.NextValue());
    }

    // use to get memory available
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    private class MEMORYSTATUSEX
    {
        public uint dwLength;
        public uint dwMemoryLoad;
        public ulong ullTotalPhys;
        public ulong ullAvailPhys;
        public ulong ullTotalPageFile;
        public ulong ullAvailPageFile;
        public ulong ullTotalVirtual;
        public ulong ullAvailVirtual;
        public ulong ullAvailExtendedVirtual;

        public MEMORYSTATUSEX()
        {
            this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
        }
    }

    [return: MarshalAs(UnmanagedType.Bool)]
    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

    /// <summary>writes exception details to the registered loggers</summary>
    /// <param name="exception">The exception to log.</param>
    public void LogException(Exception exception)
    {
      StringBuilder error = new StringBuilder();

      error.AppendLine("Application:       " + Application.ProductName);
      error.AppendLine("Version:           " + Application.ProductVersion);
      error.AppendLine("Date:              " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
      error.AppendLine("Computer name:     " + SystemInformation.ComputerName);
      error.AppendLine("User name:         " + SystemInformation.UserName);
      error.AppendLine("OS:                " + Environment.OSVersion.ToString());
      error.AppendLine("Culture:           " + CultureInfo.CurrentCulture.Name);
      error.AppendLine("Resolution:        " + SystemInformation.PrimaryMonitorSize.ToString());
      error.AppendLine("System up time:    " + GetSystemUpTime());
      error.AppendLine("App up time:       " +
        (DateTime.Now - Process.GetCurrentProcess().StartTime).ToString());

      MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
      if (GlobalMemoryStatusEx(memStatus))
      {
        error.AppendLine("Total memory:      " + memStatus.ullTotalPhys / (1024 * 1024) + "Mb");
        error.AppendLine("Available memory:  " + memStatus.ullAvailPhys / (1024 * 1024) + "Mb");
      }
      error.AppendLine("");

      error.AppendLine("Exception classes:   ");
      error.Append(GetExceptionTypeStack(exception));
      error.AppendLine("");
      error.AppendLine("Exception messages: ");
      error.Append(GetExceptionMessageStack(exception));

      error.AppendLine("");
      error.AppendLine("Stack Traces:");
      error.Append(GetExceptionCallStack(exception));
      error.AppendLine("");
      error.AppendLine("Loaded Modules:");
      Process thisProcess = Process.GetCurrentProcess();
      foreach (ProcessModule module in thisProcess.Modules)
      {
          error.AppendLine(module.FileName + " " + module.FileVersionInfo.FileVersion);
      }

      for (int i = 0; i < loggers.Count; i++)
      {
          loggers[i].LogError(error.ToString());
      }
    }
    }

}