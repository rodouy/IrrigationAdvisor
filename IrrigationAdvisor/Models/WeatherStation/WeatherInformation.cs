﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net;
using System.Text;
using System.IO;

namespace IrrigationAdvisor.Models.WeatherStation
{
    public class WeatherInformation
    {
        #region Consts
        #endregion

        #region Fields
        private WebClient webClient;
        private String webAddress;
        private byte[] raw;
        private String webData;
        private WebRequest webRequest;
        private String requestData;
        private String responseData;


        #endregion

        #region Properties
        
        public String WebAddress
        {
            get { return webAddress; }
            set { webAddress = value; }
        }

        public String WebData
        {
            get { return webData; }
            set { webData = value; }
        }

        public String RequestData
        {
            get { return requestData; }
            set { requestData = value; }
        }

        public String ResponseData
        {
            get { return responseData; }
            set { responseData = value; }
        }

        #endregion

        #region Construction
        public WeatherInformation(String pWebAddress)
        {
            webClient = new WebClient();

            WebAddress = pWebAddress;

        }

        public WeatherInformation(String pWebAddress, String pRequestData)
        {
            webClient = new WebClient();

            WebAddress = pWebAddress;

            RequestData = pRequestData;

            webRequest = (HttpWebRequest)WebRequest.Create(WebAddress);

            ResponseData = String.Empty;

        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        public void ExtractInfomationDownloadData()
        {
            raw = webClient.DownloadData(WebAddress);

            WebData = Encoding.UTF8.GetString(raw);

        }
        public void ExtractInfomationDownloadString()
        {
            WebData = webClient.DownloadString(WebAddress);
        }

        public void ExtractInfomationWebRequest()
        {
            using (StreamWriter lStreamWriter = new StreamWriter(webRequest.GetRequestStream(), Encoding.UTF8))
            {
                lStreamWriter.Write(RequestData);
            }

            HttpWebResponse lHttpWebResponse = (HttpWebResponse)webRequest.GetResponse();
            using (StreamReader lResponseReader = new StreamReader(lHttpWebResponse.GetResponseStream()))
            {
                ResponseData = lResponseReader.ReadToEnd();
            }
        }
        #endregion

        #region Overrides
        #endregion

    }
}