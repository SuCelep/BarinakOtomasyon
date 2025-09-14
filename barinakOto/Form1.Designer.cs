namespace barinakOto
{
    partial class frm_login
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
            label1 = new Label();
            label2 = new Label();
            txtKadi = new TextBox();
            txtSifre = new TextBox();
            btnLogin = new Button();
            lblHataMesaji = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(102, 39);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.Location = new Point(102, 127);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 1;
            label2.Text = "Parola";
            // 
            // txtKadi
            // 
            txtKadi.Location = new Point(102, 66);
            txtKadi.Name = "txtKadi";
            txtKadi.Size = new Size(165, 27);
            txtKadi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(102, 152);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(165, 27);
            txtSifre.TabIndex = 3;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(102, 217);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş Yap\r\n\r\n";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblHataMesaji
            // 
            lblHataMesaji.Location = new Point(12, 269);
            lblHataMesaji.Name = "lblHataMesaji";
            lblHataMesaji.Size = new Size(351, 29);
            lblHataMesaji.TabIndex = 5;
            lblHataMesaji.Visible = false;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(382, 306);
            Controls.Add(lblHataMesaji);
            Controls.Add(btnLogin);
            Controls.Add(txtSifre);
            Controls.Add(txtKadi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GİRİŞ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKadi;
        private TextBox txtSifre;
        private Button btnLogin;
        private Label lblHataMesaji;
    }
}
