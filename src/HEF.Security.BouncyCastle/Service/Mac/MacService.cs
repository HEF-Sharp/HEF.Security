using System;

namespace HEF.Security.BouncyCastle
{
    public class MacService : IMacService
    {
        public MacService(IMacProvider provider, ICryptoEncoding encoding)
        {
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));

            Encoding = encoding ?? throw new ArgumentNullException(nameof(encoding));
        }

        protected IMacProvider Provider { get; }

        protected ICryptoEncoding Encoding { get; }

        public string Encrypt(string originStr)
        {
            var encryptBytes = Provider.Encrypt(originStr);

            return Encoding.ToString(encryptBytes);
        }
    }
}
