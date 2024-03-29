﻿using System.Globalization;
using RMDP.Localization;

namespace RMDP.Utils
{
	/// <summary>
	/// Helper class to convert numbers to it's farsi equivalent. Use this class' methods to overcome a problem in displaying farsi numeric values.
	/// </summary>
	public sealed class toFarsi
	{
        /// <summary>
        /// Converts a number in string format e.g. 14500 to its localized version, if <c>Localized</c> value is set to <c>true</c>.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string Convert(string num, CultureInfo culture)
        {
            if(string.IsNullOrEmpty(num))
                return num;

			var numEnglish = "";

            for(var i=0;i<num.Length;i++)
            {
                var s = num.Substring(i,1);
                switch(s) 
				{
					case "0" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_0);
						break;
					case "1" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_1);
						break;
					case "2" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_2);
						break;
					case "3" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_3);
						break;
					case "4" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_4);
						break;
					case "5" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_5);
						break;
					case "6" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_6);
						break;
					case "7" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_7);
						break;
					case "8" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_8);
						break;
					case "9" :
                        numEnglish = numEnglish + FALocalizeManager.Instance.GetLocalizerByCulture(culture).GetLocalizedString(StringID.Numbers_9);
						break;
					default :
						numEnglish = numEnglish + s;
						break;
				}
            }

            return (numEnglish);
        }

		/// <summary>
		/// Converts an English number to it's Farsi value.
		/// </summary>
		/// <remarks>This method only converts the numbers in a string, and does not convert any non-numeric characters.</remarks>
		/// <param name="num"></param>
		/// <returns></returns>
		public static string Convert(string num)
		{
		    return Convert(num, FALocalizeManager.Instance.FarsiCulture);
		}
	}
}
