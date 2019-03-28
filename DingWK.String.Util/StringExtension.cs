using System;
using System.Collections.Generic;
using System.Text;

namespace DingWK.String.Util
{
    public static class StringExtension
    {
        #region 将字符串转换为IP地址

        /// <summary>
        /// 将字符串转换为IP地址, 成功返回 0.0.0.0 ~ 255.255.255.255, 失败返回 string.Empty。
        /// </summary>
        public static string TryToFormatIP(string str)
        {
            try
            {
                string[] ss = str.Split('.');
                for (int i = 0; i < 4; i++)
                {
                    if (int.TryParse(ss[i], out int number))
                    {
                        if (0 <= number && number <= 255)
                        {
                            ss[i] = number.ToString();
                            continue;
                        }
                    }
                    throw new Exception();
                }

                return new StringBuilder()
                   .Append(ss[0]).Append('.')
                   .Append(ss[1]).Append('.')
                   .Append(ss[2]).Append('.')
                   .Append(ss[3]).ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 将字符串转换为IP地址, 成功返回 0.0.0.0 ~ 255.255.255.255, 失败返回 string.Empty。
        /// </summary>
        public static string ToFormatIP(this string str)
        {
            return TryToFormatIP(str);
        }

        #endregion 
    }

}
