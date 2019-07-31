using System;

namespace HEF.Security.BouncyCastle
{
    public class RSAService : CipherService, ICipherService
    {
        public RSAService(IRSAProvider provider, ICryptoEncoding encoding)
            : base(provider, encoding)
        {
            RSAProvider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        protected IRSAProvider RSAProvider { get; }
    }
}
