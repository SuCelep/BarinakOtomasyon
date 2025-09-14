namespace barinakOto
{
    partial class frm_gonulluler
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
            dgvSahiplenenler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            txtKimlikNo = new TextBox();
            label3 = new Label();
            txtEposta = new TextBox();
            label4 = new Label();
            txtNum = new TextBox();
            label5 = new Label();
            txtAdres = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnTemizle = new Button();
            btnMenu = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSahiplenenler).BeginInit();
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
            panel1.Size = new Size(1093, 82);
            panel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWelcome.Location = new Point(0, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(362, 50);
            lblWelcome.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pets;
            pictureBox1.Location = new Point(931, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvSahiplenenler
            // 
            dgvSahiplenenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSahiplenenler.Dock = DockStyle.Bottom;
            dgvSahiplenenler.Location = new Point(0, 373);
            dgvSahiplenenler.Name = "dgvSahiplenenler";
            dgvSahiplenenler.RowHeadersWidth = 51;
            dgvSahiplenenler.Size = new Size(1093, 245);
            dgvSahiplenenler.TabIndex = 1;
            dgvSahiplenenler.CellClick += dgvSahiplenenler_CellClick;
            // 
            // label1
            // 
            label1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 85);
            label1.Name = "label1";
            label1.Size = new Size(167, 34);
            label1.TabIndex = 2;
            label1.Text = "Gönüllüler";
            // 
            // label2
            // 
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 3;
            label2.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(12, 147);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(162, 27);
            txtAdSoyad.TabIndex = 4;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Location = new Point(12, 222);
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(162, 27);
            txtKimlikNo.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 5;
            label3.Text = "Kimlik No";
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(12, 302);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(162, 27);
            txtEposta.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new Point(12, 274);
            label4.Name = "label4";
            label4.Size = new Size(155, 26);
            label4.TabIndex = 7;
            label4.Text = "E-Posta";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(244, 147);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(228, 27);
            txtNum.TabIndex = 10;
            // 
            // label5
            // 
            label5.Location = new Point(244, 119);
            label5.Name = "label5";
            label5.Size = new Size(221, 25);
            label5.TabIndex = 9;
            label5.Text = "Telefon Numarası";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(244, 222);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(221, 27);
            txtAdres.TabIndex = 12;
            // 
            // label6
            // 
            label6.Location = new Point(244, 194);
            label6.Name = "label6";
            label6.Size = new Size(214, 25);
            label6.TabIndex = 11;
            label6.Text = "Adres";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(843, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 291);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.ButtonShadow;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(47, 192);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(166, 29);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ButtonShadow;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(47, 243);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(166, 29);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menü";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonShadow;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(47, 140);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(166, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonShadow;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(47, 85);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(166, 29);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonShadow;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Location = new Point(47, 35);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(166, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // frm_gonulluler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1093, 618);
            Controls.Add(groupBox1);
            Controls.Add(txtAdres);
            Controls.Add(label6);
            Controls.Add(txtNum);
            Controls.Add(label5);
            Controls.Add(txtEposta);
            Controls.Add(label4);
            Controls.Add(txtKimlikNo);
            Controls.Add(label3);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSahiplenenler);
            Controls.Add(panel1);
            Name = "frm_gonulluler";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gönüllüler";
            Load += frm_gonulluler_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSahiplenenler).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblWelcome;
        private PictureBox pictureBox1;
        private DataGridView dgvSahiplenenler;
        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private TextBox txtKimlikNo;
        private Label label3;
        private TextBox txtEposta;
        private Label label4;
        private TextBox txtNum;
        private Label label5;
        private TextBox txtAdres;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnMenu;
        private Button btnTemizle;
    }
}