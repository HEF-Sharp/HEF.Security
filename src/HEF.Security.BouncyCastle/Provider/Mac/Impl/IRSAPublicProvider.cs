using Org.BouncyCastle.Crypto;

namespace HEF.Security.BouncyCastle
{
    public interface IRSAPublicProvider : IMacProvider
    {
        AsymmetricKeyParameter PublicKey { get; }
    }
}
