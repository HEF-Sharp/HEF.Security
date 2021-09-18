using HEF.Util;
using System;
using System.Security.Cryptography;
using System.Text;

namespace HEF.Security.Cryptography
{
    public static class StringEncryptExtensions
    {
        #region MD5
        /// <summary>
        /// MD5加密 字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToMD5(this string str)
        {
            return ToMD5(str, "utf-8");
        }
        /// <summary>
        /// MD5加密 字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encodeName">编码格式</param>
        /// <returns></returns>
        public static string ToMD5(this string str, string encodeName)
        {
            if (str.IsNullOrWhiteSpace())
                return string.Empty;

            var bytes = Encoding.GetEncoding(encodeName).GetBytes(str);

            return ToMD5(bytes);
        }

        /// <summary>
        /// MD5加密 二进制流
        /// </summary>
        /// <param name="bytes">二进制流</param>
        /// <returns></returns>
        public static string ToMD5(this byte[] bytes)
        {
            if (bytes.IsEmpty())            
                return string.Empty;

            using (var md5 = MD5.Create())
            {
                byte[] md5Hash = md5.ComputeHash(bytes);
                string result = BitConverter.ToString(md5Hash);

                return result.Replace("-", string.Empty);
            }
        }
        #endregion

        #region SHA256
        /// <summary>
        /// SHA256加密 字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToSHA256(this string str)
        {
            return ToSHA256(str, "utf-8");
        }
        /// <summary>
        /// SHA256加密 字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encodeName">编码格式</param>
        /// <returns></returns>
        public static string ToSHA256(this string str, string encodeName)
        {
            if (str.IsNullOrWhiteSpace())
                return string.Empty;

            var bytes = Encoding.GetEncoding(encodeName).GetBytes(str);

            return ToSHA256(bytes);
        }

        /// <summary>
        /// SHA256加密 二进制流
        /// </summary>
        /// <param name="bytes">二进制流</param>
        /// <returns></returns>
        public static string ToSHA256(this byte[] bytes)
        {
            if (bytes.IsEmpty())
                return string.Empty;

            using (var sha256 = SHA256.Create())
            {
                byte[] sha256Hash = sha256.ComputeHash(bytes);
                string result = BitConverter.ToString(sha256Hash);

                return result.Replace("-", string.Empty);
            }
        }
        #endregion
    }
}
