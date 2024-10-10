using System.Security.Cryptography;
using System.Text;

namespace WinFormsAppAsymetric
{
    internal class RSAEncryption
    {
        public static string Encrypt(string message, string publicKey)
        {
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(message);
            byte[] encryptedData;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;

                rsa.ImportRSAPublicKey(Convert.FromBase64String(publicKey), out _); // Import the public key 

                encryptedData = rsa.Encrypt(dataToEncrypt, true);
            }
            return Convert.ToBase64String(encryptedData);
        }
        public static string Decrypt(string encryptedMessage, string privateKey)
        {
            byte[] dataToDecrypt = Convert.FromBase64String(encryptedMessage);
            byte[] decryptedData;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;

                rsa.ImportRSAPrivateKey(Convert.FromBase64String(privateKey), out _); // Import the private key

                decryptedData = rsa.Decrypt(dataToDecrypt, true);
            }
            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}
