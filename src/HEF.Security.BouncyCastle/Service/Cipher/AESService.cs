using System;

namespace HEF.Security.BouncyCastle
{
    public class AESService : CipherService, ICipherService
    {
        public AESService(IAESProvider provider, ICryptoEncoding encoding)
            : base(provider, encoding)
        {
            AESProvider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        protected IAESProvider AESProvider { get; }
    }
}
