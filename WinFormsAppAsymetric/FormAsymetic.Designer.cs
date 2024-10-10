namespace WinFormsAppAsymetric
{
    partial class FormAsymetic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsymetic));
            btnGenerateAsymm = new Button();
            textBPublicKeyValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBPrivateKeyValue = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtBPlainText = new TextBox();
            txtBEncyptedText = new TextBox();
            btnEncypt = new Button();
            label5 = new Label();
            txtBSharedPublicKey = new TextBox();
            groupBox2 = new GroupBox();
            richTxtBDesencyptSharedText = new RichTextBox();
            btnDesencryptSharedText = new Button();
            textBEncryptedSharedText = new TextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            fontDialog1 = new FontDialog();
            groupBox3 = new GroupBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerateAsymm
            // 
            btnGenerateAsymm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerateAsymm.AutoSize = true;
            btnGenerateAsymm.Location = new Point(959, 175);
            btnGenerateAsymm.Name = "btnGenerateAsymm";
            btnGenerateAsymm.Size = new Size(151, 30);
            btnGenerateAsymm.TabIndex = 0;
            btnGenerateAsymm.Text = "Generar claves";
            btnGenerateAsymm.UseVisualStyleBackColor = true;
            btnGenerateAsymm.Click += btnGenerateAsymm_Click;
            // 
            // textBPublicKeyValue
            // 
            textBPublicKeyValue.Location = new Point(153, 76);
            textBPublicKeyValue.Multiline = true;
            textBPublicKeyValue.Name = "textBPublicKeyValue";
            textBPublicKeyValue.ReadOnly = true;
            textBPublicKeyValue.ScrollBars = ScrollBars.Vertical;
            textBPublicKeyValue.Size = new Size(684, 56);
            textBPublicKeyValue.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 92);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 2;
            label1.Text = "Clave publica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 175);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Clave privada";
            // 
            // textBPrivateKeyValue
            // 
            textBPrivateKeyValue.Location = new Point(153, 155);
            textBPrivateKeyValue.Multiline = true;
            textBPrivateKeyValue.Name = "textBPrivateKeyValue";
            textBPrivateKeyValue.ReadOnly = true;
            textBPrivateKeyValue.ScrollBars = ScrollBars.Vertical;
            textBPrivateKeyValue.Size = new Size(684, 50);
            textBPrivateKeyValue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 245);
            label3.Name = "label3";
            label3.Size = new Size(239, 28);
            label3.TabIndex = 5;
            label3.Text = "Proceso de Encriptacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(610, 245);
            label4.Name = "label4";
            label4.Size = new Size(274, 28);
            label4.TabIndex = 6;
            label4.Text = "Proceso de Desencriptacion";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtBPlainText);
            groupBox1.Controls.Add(btnEncypt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBSharedPublicKey);
            groupBox1.Location = new Point(51, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 391);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 224);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 13;
            label7.Text = "Texto Plano";
            // 
            // txtBPlainText
            // 
            txtBPlainText.Location = new Point(6, 246);
            txtBPlainText.Multiline = true;
            txtBPlainText.Name = "txtBPlainText";
            txtBPlainText.PlaceholderText = "El texto que quieres encriptar";
            txtBPlainText.ScrollBars = ScrollBars.Vertical;
            txtBPlainText.Size = new Size(444, 104);
            txtBPlainText.TabIndex = 2;
            txtBPlainText.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBEncyptedText
            // 
            txtBEncyptedText.Location = new Point(6, 36);
            txtBEncyptedText.Multiline = true;
            txtBEncyptedText.Name = "txtBEncyptedText";
            txtBEncyptedText.ScrollBars = ScrollBars.Vertical;
            txtBEncyptedText.Size = new Size(444, 98);
            txtBEncyptedText.TabIndex = 4;
            // 
            // btnEncypt
            // 
            btnEncypt.Location = new Point(180, 356);
            btnEncypt.Name = "btnEncypt";
            btnEncypt.Size = new Size(94, 29);
            btnEncypt.TabIndex = 3;
            btnEncypt.Text = "Encriptar";
            btnEncypt.UseVisualStyleBackColor = true;
            btnEncypt.Click += btnEncypt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 20);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 9;
            label5.Text = "Clave Publica";
            // 
            // txtBSharedPublicKey
            // 
            txtBSharedPublicKey.Location = new Point(6, 46);
            txtBSharedPublicKey.Multiline = true;
            txtBSharedPublicKey.Name = "txtBSharedPublicKey";
            txtBSharedPublicKey.ScrollBars = ScrollBars.Vertical;
            txtBSharedPublicKey.Size = new Size(444, 175);
            txtBSharedPublicKey.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(richTxtBDesencyptSharedText);
            groupBox2.Controls.Add(btnDesencryptSharedText);
            groupBox2.Controls.Add(textBEncryptedSharedText);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(610, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 391);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // richTxtBDesencyptSharedText
            // 
            richTxtBDesencyptSharedText.BorderStyle = BorderStyle.FixedSingle;
            richTxtBDesencyptSharedText.Location = new Point(22, 246);
            richTxtBDesencyptSharedText.Name = "richTxtBDesencyptSharedText";
            richTxtBDesencyptSharedText.Size = new Size(518, 125);
            richTxtBDesencyptSharedText.TabIndex = 7;
            richTxtBDesencyptSharedText.Text = "";
            // 
            // btnDesencryptSharedText
            // 
            btnDesencryptSharedText.Location = new Point(430, 31);
            btnDesencryptSharedText.Name = "btnDesencryptSharedText";
            btnDesencryptSharedText.Size = new Size(110, 29);
            btnDesencryptSharedText.TabIndex = 6;
            btnDesencryptSharedText.Text = "Desencriptar";
            btnDesencryptSharedText.UseVisualStyleBackColor = true;
            btnDesencryptSharedText.Click += btnDesencryptSharedText_Click;
            // 
            // textBEncryptedSharedText
            // 
            textBEncryptedSharedText.Location = new Point(22, 66);
            textBEncryptedSharedText.Multiline = true;
            textBEncryptedSharedText.Name = "textBEncryptedSharedText";
            textBEncryptedSharedText.Size = new Size(518, 111);
            textBEncryptedSharedText.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 40);
            label8.Name = "label8";
            label8.Size = new Size(205, 20);
            label8.TabIndex = 15;
            label8.Text = "Texto Encriptado Compartido";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(959, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "ania";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(231, 28);
            label9.Name = "label9";
            label9.Size = new Size(460, 31);
            label9.TabIndex = 10;
            label9.Text = "Form para Algoritmo Asimetrico Con RSA";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBEncyptedText);
            groupBox3.Location = new Point(51, 701);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(456, 152);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Texto Encriptado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 223);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 16;
            label6.Text = "Resultado";
            // 
            // FormAsymetic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 906);
            Controls.Add(groupBox3);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBPrivateKeyValue);
            Controls.Add(label1);
            Controls.Add(textBPublicKeyValue);
            Controls.Add(btnGenerateAsymm);
            Name = "FormAsymetic";
            Text = "Algoritmo asimetrico";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateAsymm;
        private TextBox textBPublicKeyValue;
        private Label label1;
        private Label label2;
        private TextBox textBPrivateKeyValue;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtBSharedPublicKey;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox txtBPlainText;
        private TextBox txtBEncyptedText;
        private Button btnEncypt;
        private Label label8;
        private RichTextBox richTxtBDesencyptSharedText;
        private Button btnDesencryptSharedText;
        private TextBox textBEncryptedSharedText;
        private PictureBox pictureBox1;
        private Label label9;
        private FontDialog fontDialog1;
        private GroupBox groupBox3;
        private Label label6;
    }
}
