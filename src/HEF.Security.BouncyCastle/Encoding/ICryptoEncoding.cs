namespace HEF.Security.BouncyCastle
{
    public interface ICryptoEncoding
    {
        /// <summary>
        /// 编码
        /// </summary>
        /// <param name="encryptBytes">加密数据</param>
        /// <returns></returns>
        string ToString(byte[] encryptBytes);

        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="encryptStr">加密字符串</param>
        /// <returns></returns>
        byte[] FromString(string encryptStr);
    }
}
