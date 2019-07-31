using Org.BouncyCastle.Crypto.Parameters;

namespace HEF.Security.BouncyCastle
{
    public interface IAESProvider : ICipherProvider
    {
        ParametersWithIV KeyWithIV { get; }

        byte[] IV { get; }
    }
}
