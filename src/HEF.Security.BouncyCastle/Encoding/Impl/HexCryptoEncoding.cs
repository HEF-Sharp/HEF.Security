using HEF.Util;
using Org.BouncyCastle.Utilities.Encoders;

namespace HEF.Security.BouncyCastle
{
    public class HexCryptoEncoding : ICryptoEncoding
    {
        public string ToString(byte[] encryptBytes)
        {
            if (encryptBytes.IsEmpty())
                return string.Empty;

            return Hex.ToHexString(encryptBytes);
        }

        public byte[] FromString(string encryptStr)
        {
            if (string.IsNullOrWhiteSpace(encryptStr))
                return null;

            return Hex.Decode(encryptStr);
        }
    }
}
