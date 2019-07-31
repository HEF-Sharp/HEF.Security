using System;

namespace HEF.Security.BouncyCastle
{
    public class RSAPublicService : MacService, IMacService
    {
        public RSAPublicService(IRSAPublicProvider provider, ICryptoEncoding encoding)
            : base(provider, encoding)
        {
            RSAPublicProvider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        protected IRSAPublicProvider RSAPublicProvider { get; }
    }
}
