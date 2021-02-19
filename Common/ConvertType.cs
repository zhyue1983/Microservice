using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Common
{
    public static class ConvertType
    {
        public static int ToIntByStr(this string str, int defValue)
        {
            if (string.IsNullOrEmpty(str) || str.Trim().Length >= 11 || !Regex.IsMatch(str.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            int rv;
            if (Int32.TryParse(str, out rv))
            {
                return rv;
            }
            else
            {
                return Convert.ToInt32(ToFloatByStr(str, defValue));
            }
        }
        public static int ToIntByStr(this string str)
        {
            return ToIntByStr(str, 0);
        }

        public static float ToFloatByStr(this string str, int defValue)
        {
            if ((str == null) || (str.Length > 10))
                return defValue;

            float intValue = defValue;
            if (str != null)
            {
                bool IsFloat = Regex.IsMatch(str, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsFloat)
                {
                    float.TryParse(str, out intValue);
                }
            }
            return intValue;
        }
        public static float ToFloatByStr(this string str)
        {
            if ((str == null))
                return 0;

            return ToFloatByStr(str.ToString(), 0);
        }





        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime ToDateTimeByStr(this string str, DateTime defValue)
        {
            if (!string.IsNullOrEmpty(str))
            {
                DateTime dateTime;
                if (DateTime.TryParse(str, out dateTime))
                {
                    return dateTime;
                }
            }
            return defValue;
        }

        /// <summary>
        /// 将对象转换为日期时间类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <returns>转换后的int类型结果</returns>
        public static DateTime ToDateTimeByStr(this string str)
        {
            return ToDateTimeByStr(str, new DateTime(1900, 1, 1));
        }

        /// <summary>
        /// string型转换为bool型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool ToBoolByStr(this string expression)
        {
            if (expression != null)
            {
                if (string.Compare(expression, "true", true) == 0)
                {
                    return true;
                }
                else if (string.Compare(expression, "false", true) == 0)
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// string型转换为double型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的double类型结果</returns>
        public static double ToDoubleByStr(this string strValue, double defValue)
        {
            if ((strValue == null) || (strValue.Length > 10))
            {
                return defValue;
            }
            double intValue = defValue;
            if (strValue != null)
            {
                bool IsDouble = Regex.IsMatch(strValue, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsDouble)
                {
                    double.TryParse(strValue, out intValue);
                }
            }
            return intValue;
        }
        /// <summary>
        /// string型转换为double型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的double类型结果</returns>
        public static double ToDoubleByStr(this string strValue)
        {

            return ToDoubleByStr(strValue, 0.0);
        }

        /// <summary>
        /// string型转换为Decimal型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Decimal类型结果</returns>
        public static decimal ToPriceDecimalByStr(this string strValue, decimal defValue)
        {
            if ((strValue == null) || (strValue.Length > 10))
            {
                return defValue;
            }
            decimal intValue = defValue;
            if (strValue != null)
            {
                bool IsFloat = Regex.IsMatch(strValue, @"^-?\d+(\.\d{1,2})?$");
                if (IsFloat)
                    decimal.TryParse(strValue, out intValue);
            }
            return intValue;
        }
        /// <summary>
        /// string型转换为Decimal型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的Decimal类型结果</returns>
        public static decimal ToPriceDecimalByStr(this string strValue)
        {
            decimal defaultValue = 0.00m;
            return ToPriceDecimalByStr(strValue, defaultValue);
        }


        public static string SubString(this string str, int num, string defaultStr)
        {
            string res = "";
            if (str != null)
            {
                if (str.Length >= num)
                {
                    res = str.Substring(0, num) + defaultStr;
                }
                else
                {
                    res = str;
                }
            }
            else
            {
                return "";
            }
            return res;
        }
    }
}