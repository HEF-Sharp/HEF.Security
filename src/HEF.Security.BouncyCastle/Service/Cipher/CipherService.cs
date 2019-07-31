using System;

namespace HEF.Security.BouncyCastle
{
    public class CipherService : ICipherService
    {
        public CipherService(ICipherProvider provider, ICryptoEncoding encoding)
        {
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));

            Encoding = encoding ?? throw new ArgumentNullException(nameof(encoding));
        }

        protected ICipherProvider Provider { get; }

        protected ICryptoEncoding Encoding { get; }

        public string Encrypt(string originStr)
        {
            var encryptBytes = Provider.Encrypt(originStr);

            return Encoding.ToString(encryptBytes);
        }

        public string Decrypt(string encryptStr)
        {
            var encryptBytes = Encoding.FromString(encryptStr);

            return Provider.Decrypt(encryptBytes);
        }
    }
}
