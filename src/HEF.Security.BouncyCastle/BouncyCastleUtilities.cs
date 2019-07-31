using System;
using System.IO;

namespace HEF.Security.BouncyCastle
{
    internal static class BouncyCastleUtilities
    {
        internal static Stream GetFileStreamFromAppDomainDirectory(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (!File.Exists(filePath))
                return null;

            return File.OpenRead(filePath);
        }
    }
}
