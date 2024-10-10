using System.Security.Cryptography;

namespace WinFormsAppAsymetric
{
    public class RSAKeyPair
    {
        public string PublicKey { get; private set; }
        public string PrivateKey { get; private set; }

        public RSAKeyPair()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false; // Don't store the key in a key container

                PublicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());

                PrivateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());
            }
        }
    }
}
