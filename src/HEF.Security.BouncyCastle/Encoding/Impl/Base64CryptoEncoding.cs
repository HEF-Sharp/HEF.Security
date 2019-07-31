using HEF.Util;
using Org.BouncyCastle.Utilities.Encoders;

namespace HEF.Security.BouncyCastle
{
    public class Base64CryptoEncoding : ICryptoEncoding
    {
        public string ToString(byte[] encryptBytes)
        {
            if (encryptBytes.IsEmpty())
                return string.Empty;

            return Base64.ToBase64String(encryptBytes);
        }

        public byte[] FromString(string encryptStr)
        {
            if (string.IsNullOrWhiteSpace(encryptStr))
                return null;

            return Base64.Decode(encryptStr);
        }
    }
}
