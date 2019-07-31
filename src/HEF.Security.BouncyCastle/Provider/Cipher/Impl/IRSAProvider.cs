using Org.BouncyCastle.Crypto;

namespace HEF.Security.BouncyCastle
{
    public interface IRSAProvider : ICipherProvider
    {
        AsymmetricKeyParameter PublicKey { get; }

        AsymmetricKeyParameter PrivateKey { get; }
    }
}
