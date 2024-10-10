namespace WinFormsAppAsymetric
{
    public partial class FormAsymetic : Form
    {
        private RSAKeyPair rsaKeyPair;
        public FormAsymetic()
        {
            InitializeComponent();
        }

        private void btnGenerateAsymm_Click(object sender, EventArgs e)
        {
            rsaKeyPair = new RSAKeyPair();
            textBPublicKeyValue.Text = rsaKeyPair.PublicKey;
            textBPrivateKeyValue.Text = rsaKeyPair.PrivateKey;

            txtBSharedPublicKey.Text = rsaKeyPair.PublicKey;
        }

        private void btnEncypt_Click(object sender, EventArgs e)
        {
            string publicKey = txtBSharedPublicKey.Text;
            string message = txtBPlainText.Text;

            string encryptedMessage = RSAEncryption.Encrypt(message, publicKey);

            txtBEncyptedText.Text = encryptedMessage;
        }

        private void btnDesencryptSharedText_Click(object sender, EventArgs e)
        {
            string txtEncrypted = txtBEncyptedText.Text;
            string privateKey = textBPrivateKeyValue.Text;

            string decryptedMessage = RSAEncryption.Decrypt(txtEncrypted, privateKey);

            richTxtBDesencyptSharedText.Text = decryptedMessage;


        }
    }
}
