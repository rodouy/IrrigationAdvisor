using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Drawing;

namespace IrrigationAdvisor.Models.Utilities
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy 
    /// Description: 
    ///     Class that represent all the colors to use
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    /// 
    /// Methods:
    ///     - ColorName(order, name, Color)      -- constructor
    ///     - getRed(ColorName)  -- return the red color of a ColorName
    ///     - getGreen(ColorName)  -- return the green color of a ColorName
    ///     - getBlue(ColorName)  -- return the blue color of a ColorName
    ///     - getAlpha(ColorName)  -- return the alpha color of a ColorName
    ///     
    ///     - getColorName(order)     -- method to get the ColorName from the order
    ///     - getColorName(name)     -- method to get the ColorName from the name
    ///     
    /// 
    /// </summary>
    public sealed class ColorName
    {
        #region Consts
        private readonly Color color;
        private readonly String name;
        private readonly int order;

        #endregion

        #region Fields
        #endregion

        #region Properties
        public static readonly ColorName WHITE = new ColorName(1, "Blanco", Color.White);
        public static readonly ColorName BLACK = new ColorName(2, "Negro", Color.Black);
        public static readonly ColorName CYAN = new ColorName(3, "Cyan", Color.Cyan);
        public static readonly ColorName MAGENTA = new ColorName(4, "Magenta", Color.Magenta);
        public static readonly ColorName YELLOW = new ColorName(5, "Amarillo", Color.Yellow);
        public static readonly ColorName RED = new ColorName(6, "Rojo", Color.Red);
        public static readonly ColorName BLUE = new ColorName(7, "Azul", Color.Blue);
        public static readonly ColorName GREEN = new ColorName(8, "Verde", Color.Green);
        public static readonly ColorName VIOLET = new ColorName(9, "Violeta", Color.Violet);
        public static readonly ColorName ORANGE = new ColorName(10, "Naranja", Color.Orange);
        public static readonly ColorName GRAY = new ColorName(11, "Gris", Color.Gray);
        public static readonly ColorName BROWN = new ColorName(12, "Marron", Color.Brown);
        public static readonly ColorName BEIGE = new ColorName(13, "Beige", Color.Beige);
        public static readonly ColorName PINK = new ColorName(14, "Rosa", Color.Pink);
        public static readonly ColorName FUCHSIA = new ColorName(15, "Fuchsia", Color.Fuchsia);
        public static readonly ColorName TRANSPARENT = new ColorName(0, "Transparente", Color.Transparent);

        #endregion

        #region Construction
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pOrder"></param>
        /// <param name="pName"></param>
        /// <param name="pColor"></param>
        private ColorName
            (
            int pOrder, 
            String pName,
            Color pColor
            )
        {
            this.order = pOrder;
            this.name = pName;
            this.color = pColor;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        public byte getRed(ColorName pColor)
        {
            return pColor.color.R;
        }
        public byte getGreen(ColorName pColor)
        {
            return pColor.color.G;
        }
        public byte getBlue(ColorName pColor)
        {
            return pColor.color.B;
        }
        public byte getAlpha(ColorName pColor)
        {
            return pColor.color.A;
        }

        /// <summary>
        /// Return the ColorName from the order.
        /// </summary>
        /// <param name="pOrder"></param>
        /// <returns></returns>
        public static ColorName getColorName(int pOrder)
        {
            ColorName lColorName = null;
            switch (pOrder)
            {
                case 0:
                    lColorName = ColorName.TRANSPARENT;
                    break;
                case 1:
                    lColorName = ColorName.WHITE;
                    break;
                case 2:
                    lColorName = ColorName.BLACK;
                    break;
                case 3:
                    lColorName = ColorName.CYAN;
                    break;
                case 4:
                    lColorName = ColorName.MAGENTA;
                    break;
                case 5:
                    lColorName = ColorName.YELLOW;
                    break;
                case 6:
                    lColorName = ColorName.RED;
                    break;
                case 7:
                    lColorName = ColorName.BLUE;
                    break;
                case 8:
                    lColorName = ColorName.GREEN;
                    break;
                case 9:
                    lColorName = ColorName.VIOLET;
                    break;
                case 10:
                    lColorName = ColorName.ORANGE;
                    break;
                case 11:
                    lColorName = ColorName.GRAY;
                    break;
                case 12:
                    lColorName = ColorName.BROWN;
                    break;
                case 13:
                    lColorName = ColorName.BEIGE;
                    break;
                case 14:
                    lColorName = ColorName.PINK;
                    break;
                case 15:
                    lColorName = ColorName.FUCHSIA;
                    break;
                default:
                    break;
            }
            return lColorName;
        }
        public static ColorName getColorName(String pName)
        {
            ColorName lColorName = null;
            switch (pName.ToUpper())
            {
                case "TRANSPARENTE":
                case "TRANSPARENT":
                    lColorName = ColorName.TRANSPARENT;
                    break;
                case "BLANCO":
                case "WHITE":
                    lColorName = ColorName.WHITE;
                    break;
                case "NEGRO":
                case "BLACK":
                    lColorName = ColorName.BLACK;
                    break;
                case "CYAN":
                    lColorName = ColorName.CYAN;
                    break;
                case "MAGENTA":
                    lColorName = ColorName.MAGENTA;
                    break;
                case "AMARILLO":
                case "YELLOW":
                    lColorName = ColorName.YELLOW;
                    break;
                case "ROJO":
                case "RED":
                    lColorName = ColorName.RED;
                    break;
                case "AZUL":
                case "BLUE":
                    lColorName = ColorName.BLUE;
                    break;
                case "VERDE":
                case "GREEN":
                    lColorName = ColorName.GREEN;
                    break;
                case "VIOLETA":
                case "VIOLET":
                    lColorName = ColorName.VIOLET;
                    break;
                case "NARANJA":
                case "ORANGE":
                    lColorName = ColorName.ORANGE;
                    break;
                case "GRIS":
                case "GRAY":
                    lColorName = ColorName.GRAY;
                    break;
                case "MARRON":
                case "BROWN":
                    lColorName = ColorName.BROWN;
                    break;
                case "BEIGE":
                    lColorName = ColorName.BEIGE;
                    break;
                case "ROSA":
                case "PINK":
                    lColorName = ColorName.PINK;
                    break;
                case "FUCHSIA":
                    lColorName = ColorName.FUCHSIA;
                    break;
                default:
                    break;
            }
            return lColorName;
        }
        
        #endregion

        #region Overrides
        /// <summary>
        /// override of ToString, return the name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }
        #endregion


    }
}