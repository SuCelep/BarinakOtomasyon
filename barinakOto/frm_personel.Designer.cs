namespace barinakOto
{
    partial class frm_personel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            dgvPersonel = new DataGridView();
            groupBox1 = new GroupBox();
            btnMenu = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            label1 = new Label();
            txtAdSoyad = new TextBox();
            txtGorev = new TextBox();
            label2 = new Label();
            txtTel = new TextBox();
            label3 = new Label();
            txtPosta = new TextBox();
            label4 = new Label();
            txtKullaniciAdi = new TextBox();
            label5 = new Label();
            txtSifre = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 125);
            panel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWelcome.Location = new Point(3, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(406, 50);
            lblWelcome.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.people;
            pictureBox1.Location = new Point(1172, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvPersonel
            // 
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.Dock = DockStyle.Bottom;
            dgvPersonel.Location = new Point(0, 458);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.RowHeadersWidth = 51;
            dgvPersonel.Size = new Size(1334, 248);
            dgvPersonel.TabIndex = 1;
            dgvPersonel.CellClick += dgvPersonel_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(1084, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 333);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ButtonShadow;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(28, 245);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(210, 29);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "MENÜ";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.ButtonShadow;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(28, 197);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(210, 29);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonShadow;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(28, 152);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(210, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonShadow;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(28, 102);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(210, 29);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonShadow;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Location = new Point(28, 59);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(210, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 144);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 3;
            label1.Text = "Personel Adı Soyadı";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(12, 172);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(257, 27);
            txtAdSoyad.TabIndex = 4;
            // 
            // txtGorev
            // 
            txtGorev.Location = new Point(12, 256);
            txtGorev.Name = "txtGorev";
            txtGorev.Size = new Size(257, 27);
            txtGorev.TabIndex = 6;
            // 
            // label2
            // 
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(257, 25);
            label2.TabIndex = 5;
            label2.Text = "Görev";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(12, 338);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(257, 27);
            txtTel.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(12, 310);
            label3.Name = "label3";
            label3.Size = new Size(257, 25);
            label3.TabIndex = 7;
            label3.Text = "Telefon Numarası";
            // 
            // txtPosta
            // 
            txtPosta.Location = new Point(12, 417);
            txtPosta.Name = "txtPosta";
            txtPosta.Size = new Size(257, 27);
            txtPosta.TabIndex = 10;
            // 
            // label4
            // 
            label4.Location = new Point(12, 389);
            label4.Name = "label4";
            label4.Size = new Size(257, 25);
            label4.TabIndex = 9;
            label4.Text = "E-Posta";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(494, 243);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(214, 27);
            txtKullaniciAdi.TabIndex = 12;
            // 
            // label5
            // 
            label5.Location = new Point(494, 215);
            label5.Name = "label5";
            label5.Size = new Size(214, 25);
            label5.TabIndex = 11;
            label5.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(494, 327);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(214, 27);
            txtSifre.TabIndex = 14;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.Location = new Point(494, 299);
            label6.Name = "label6";
            label6.Size = new Size(214, 25);
            label6.TabIndex = 13;
            label6.Text = "Parola\r\n";
            // 
            // label7
            // 
            label7.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(494, 153);
            label7.Name = "label7";
            label7.Size = new Size(149, 32);
            label7.TabIndex = 15;
            label7.Text = "Zorunlu Alan *";
            // 
            // frm_personel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1334, 706);
            Controls.Add(label7);
            Controls.Add(txtSifre);
            Controls.Add(label6);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label5);
            Controls.Add(txtPosta);
            Controls.Add(label4);
            Controls.Add(txtTel);
            Controls.Add(label3);
            Controls.Add(txtGorev);
            Controls.Add(label2);
            Controls.Add(txtAdSoyad);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgvPersonel);
            Controls.Add(panel1);
            Name = "frm_personel";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel İşlemleri";
            Load += frm_personel_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblWelcome;
        private PictureBox pictureBox1;
        private DataGridView dgvPersonel;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtAdSoyad;
        private TextBox txtGorev;
        private Label label2;
        private TextBox txtTel;
        private Label label3;
        private TextBox txtPosta;
        private Label label4;
        private TextBox txtKullaniciAdi;
        private Label label5;
        private TextBox txtSifre;
        private Label label6;
        private Button btnMenu;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private Label label7;
    }
}