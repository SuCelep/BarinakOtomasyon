namespace barinakOto
{
    partial class frm_veteriner
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbHayvanSecimi = new ComboBox();
            dgvAsilar = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtAsiAdi = new TextBox();
            label4 = new Label();
            dtpAsiTarihi = new DateTimePicker();
            dtpSonrakiAsiTarihi = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtVetAdi = new TextBox();
            dgvSaglikKayitlari = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            txtSVetAdi = new TextBox();
            label9 = new Label();
            rtxtTeshis = new RichTextBox();
            rtxtTedavi = new RichTextBox();
            label10 = new Label();
            rtxtNotlar = new RichTextBox();
            label11 = new Label();
            groupBox1 = new GroupBox();
            btnAsiGuncelle = new Button();
            btnAsiSil = new Button();
            btnAsiEkle = new Button();
            groupBox2 = new GroupBox();
            btnKayitGuncelle = new Button();
            btnKayitSil = new Button();
            btnSaglikEkle = new Button();
            btnMenu = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaglikKayitlari).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbHayvanSecimi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 70);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.heart;
            pictureBox1.Location = new Point(1177, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(86, 20);
            label1.Name = "label1";
            label1.Size = new Size(291, 37);
            label1.TabIndex = 1;
            label1.Text = "Hayvanı Giriniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbHayvanSecimi
            // 
            cmbHayvanSecimi.FormattingEnabled = true;
            cmbHayvanSecimi.Location = new Point(422, 29);
            cmbHayvanSecimi.Name = "cmbHayvanSecimi";
            cmbHayvanSecimi.Size = new Size(486, 28);
            cmbHayvanSecimi.TabIndex = 0;
            cmbHayvanSecimi.SelectedIndexChanged += cmbHayvanSecimi_SelectedIndexChanged;
            // 
            // dgvAsilar
            // 
            dgvAsilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsilar.Dock = DockStyle.Left;
            dgvAsilar.Location = new Point(0, 70);
            dgvAsilar.Name = "dgvAsilar";
            dgvAsilar.RowHeadersWidth = 51;
            dgvAsilar.Size = new Size(291, 608);
            dgvAsilar.TabIndex = 1;
            dgvAsilar.CellClick += dgvAsilar_CellClick;
            // 
            // label2
            // 
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(296, 72);
            label2.Name = "label2";
            label2.Size = new Size(126, 37);
            label2.TabIndex = 2;
            label2.Text = "Aşı Bilgileri";
            // 
            // label3
            // 
            label3.Location = new Point(296, 109);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 3;
            label3.Text = "Aşı Adı";
            // 
            // txtAsiAdi
            // 
            txtAsiAdi.BorderStyle = BorderStyle.FixedSingle;
            txtAsiAdi.Location = new Point(296, 137);
            txtAsiAdi.Name = "txtAsiAdi";
            txtAsiAdi.Size = new Size(125, 27);
            txtAsiAdi.TabIndex = 4;
            // 
            // label4
            // 
            label4.Location = new Point(296, 167);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 5;
            label4.Text = "Aşı Tarihi";
            // 
            // dtpAsiTarihi
            // 
            dtpAsiTarihi.Location = new Point(296, 195);
            dtpAsiTarihi.Name = "dtpAsiTarihi";
            dtpAsiTarihi.Size = new Size(215, 27);
            dtpAsiTarihi.TabIndex = 6;
            // 
            // dtpSonrakiAsiTarihi
            // 
            dtpSonrakiAsiTarihi.Location = new Point(296, 253);
            dtpSonrakiAsiTarihi.Name = "dtpSonrakiAsiTarihi";
            dtpSonrakiAsiTarihi.Size = new Size(215, 27);
            dtpSonrakiAsiTarihi.TabIndex = 8;
            // 
            // label5
            // 
            label5.Location = new Point(296, 225);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 7;
            label5.Text = "Sonraki Aşı Tarihi";
            // 
            // label6
            // 
            label6.Location = new Point(296, 283);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 9;
            label6.Text = "Aşıyı Yapan Veteriner\r\n";
            // 
            // txtVetAdi
            // 
            txtVetAdi.BorderStyle = BorderStyle.FixedSingle;
            txtVetAdi.Location = new Point(297, 311);
            txtVetAdi.Name = "txtVetAdi";
            txtVetAdi.Size = new Size(214, 27);
            txtVetAdi.TabIndex = 10;
            // 
            // dgvSaglikKayitlari
            // 
            dgvSaglikKayitlari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaglikKayitlari.Dock = DockStyle.Right;
            dgvSaglikKayitlari.Location = new Point(1009, 70);
            dgvSaglikKayitlari.Name = "dgvSaglikKayitlari";
            dgvSaglikKayitlari.RowHeadersWidth = 51;
            dgvSaglikKayitlari.Size = new Size(340, 608);
            dgvSaglikKayitlari.TabIndex = 11;
            dgvSaglikKayitlari.CellClick += dgvSaglikKayitlari_CellClick;
            // 
            // label7
            // 
            label7.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(830, 70);
            label7.Name = "label7";
            label7.Size = new Size(173, 37);
            label7.TabIndex = 12;
            label7.Text = "Sağlık Kayıtları";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(918, 107);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 13;
            label8.Text = "Teşhis";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtSVetAdi
            // 
            txtSVetAdi.BorderStyle = BorderStyle.FixedSingle;
            txtSVetAdi.Location = new Point(795, 354);
            txtSVetAdi.Name = "txtSVetAdi";
            txtSVetAdi.Size = new Size(208, 27);
            txtSVetAdi.TabIndex = 16;
            // 
            // label9
            // 
            label9.Location = new Point(918, 181);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 15;
            label9.Text = "Tedavi";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // rtxtTeshis
            // 
            rtxtTeshis.Location = new Point(830, 135);
            rtxtTeshis.Name = "rtxtTeshis";
            rtxtTeshis.Size = new Size(173, 43);
            rtxtTeshis.TabIndex = 17;
            rtxtTeshis.Text = "";
            // 
            // rtxtTedavi
            // 
            rtxtTedavi.Location = new Point(830, 209);
            rtxtTedavi.Name = "rtxtTedavi";
            rtxtTedavi.Size = new Size(173, 43);
            rtxtTedavi.TabIndex = 18;
            rtxtTedavi.Text = "";
            // 
            // label10
            // 
            label10.Location = new Point(918, 258);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 19;
            label10.Text = "Notlar";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // rtxtNotlar
            // 
            rtxtNotlar.Location = new Point(830, 280);
            rtxtNotlar.Name = "rtxtNotlar";
            rtxtNotlar.Size = new Size(173, 43);
            rtxtNotlar.TabIndex = 20;
            rtxtNotlar.Text = "";
            // 
            // label11
            // 
            label11.Location = new Point(853, 326);
            label11.Name = "label11";
            label11.Size = new Size(150, 25);
            label11.TabIndex = 21;
            label11.Text = " Veteriner\r\n";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAsiGuncelle);
            groupBox1.Controls.Add(btnAsiSil);
            groupBox1.Controls.Add(btnAsiEkle);
            groupBox1.Location = new Point(296, 354);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 179);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aşı İşlemleri";
            // 
            // btnAsiGuncelle
            // 
            btnAsiGuncelle.BackColor = SystemColors.ButtonShadow;
            btnAsiGuncelle.FlatStyle = FlatStyle.Popup;
            btnAsiGuncelle.Location = new Point(43, 115);
            btnAsiGuncelle.Name = "btnAsiGuncelle";
            btnAsiGuncelle.Size = new Size(172, 29);
            btnAsiGuncelle.TabIndex = 2;
            btnAsiGuncelle.Text = "Aşı Güncelle";
            btnAsiGuncelle.UseVisualStyleBackColor = false;
            btnAsiGuncelle.Click += btnAsiGuncelle_Click;
            // 
            // btnAsiSil
            // 
            btnAsiSil.BackColor = SystemColors.ButtonShadow;
            btnAsiSil.FlatStyle = FlatStyle.Popup;
            btnAsiSil.Location = new Point(43, 80);
            btnAsiSil.Name = "btnAsiSil";
            btnAsiSil.Size = new Size(172, 29);
            btnAsiSil.TabIndex = 1;
            btnAsiSil.Text = "Aşı Sil";
            btnAsiSil.UseVisualStyleBackColor = false;
            btnAsiSil.Click += btnAsiSil_Click;
            // 
            // btnAsiEkle
            // 
            btnAsiEkle.BackColor = SystemColors.ButtonShadow;
            btnAsiEkle.FlatStyle = FlatStyle.Popup;
            btnAsiEkle.Location = new Point(43, 45);
            btnAsiEkle.Name = "btnAsiEkle";
            btnAsiEkle.Size = new Size(172, 29);
            btnAsiEkle.TabIndex = 0;
            btnAsiEkle.Text = "Yeni Aşı Ekle";
            btnAsiEkle.UseVisualStyleBackColor = false;
            btnAsiEkle.Click += btnAsiEkle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnKayitGuncelle);
            groupBox2.Controls.Add(btnKayitSil);
            groupBox2.Controls.Add(btnSaglikEkle);
            groupBox2.Location = new Point(753, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 179);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sağlık İşlemleri";
            // 
            // btnKayitGuncelle
            // 
            btnKayitGuncelle.BackColor = SystemColors.ButtonShadow;
            btnKayitGuncelle.FlatStyle = FlatStyle.Popup;
            btnKayitGuncelle.Location = new Point(42, 96);
            btnKayitGuncelle.Name = "btnKayitGuncelle";
            btnKayitGuncelle.Size = new Size(172, 29);
            btnKayitGuncelle.TabIndex = 2;
            btnKayitGuncelle.Text = "Sağlık Kaydı Güncelle";
            btnKayitGuncelle.UseVisualStyleBackColor = false;
            btnKayitGuncelle.Click += btnKayitGuncelle_Click;
            // 
            // btnKayitSil
            // 
            btnKayitSil.BackColor = SystemColors.ButtonShadow;
            btnKayitSil.FlatStyle = FlatStyle.Popup;
            btnKayitSil.Location = new Point(42, 61);
            btnKayitSil.Name = "btnKayitSil";
            btnKayitSil.Size = new Size(172, 29);
            btnKayitSil.TabIndex = 1;
            btnKayitSil.Text = "Sağlık Kaydı Sil";
            btnKayitSil.UseVisualStyleBackColor = false;
            btnKayitSil.Click += btnKayitSil_Click;
            // 
            // btnSaglikEkle
            // 
            btnSaglikEkle.BackColor = SystemColors.ButtonShadow;
            btnSaglikEkle.FlatStyle = FlatStyle.Popup;
            btnSaglikEkle.Location = new Point(42, 26);
            btnSaglikEkle.Name = "btnSaglikEkle";
            btnSaglikEkle.Size = new Size(172, 29);
            btnSaglikEkle.TabIndex = 0;
            btnSaglikEkle.Text = "Yeni Sağlık Kaydı Ekle";
            btnSaglikEkle.UseVisualStyleBackColor = false;
            btnSaglikEkle.Click += btnSaglikEkle_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ButtonShadow;
            btnMenu.FlatStyle = FlatStyle.Popup;
            btnMenu.Location = new Point(321, 637);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(172, 29);
            btnMenu.TabIndex = 24;
            btnMenu.Text = "Menü\r\n";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // frm_veteriner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1349, 678);
            Controls.Add(btnMenu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label11);
            Controls.Add(rtxtNotlar);
            Controls.Add(label10);
            Controls.Add(rtxtTedavi);
            Controls.Add(rtxtTeshis);
            Controls.Add(txtSVetAdi);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvSaglikKayitlari);
            Controls.Add(txtVetAdi);
            Controls.Add(label6);
            Controls.Add(dtpSonrakiAsiTarihi);
            Controls.Add(label5);
            Controls.Add(dtpAsiTarihi);
            Controls.Add(label4);
            Controls.Add(txtAsiAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvAsilar);
            Controls.Add(panel1);
            Name = "frm_veteriner";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veteriner";
            Load += frm_veteriner_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaglikKayitlari).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbHayvanSecimi;
        private DataGridView dgvAsilar;
        private Label label2;
        private Label label3;
        private TextBox txtAsiAdi;
        private Label label4;
        private DateTimePicker dtpAsiTarihi;
        private DateTimePicker dtpSonrakiAsiTarihi;
        private Label label5;
        private Label label6;
        private TextBox txtVetAdi;
        private DataGridView dgvSaglikKayitlari;
        private Label label7;
        private TextBox txtTeshis;
        private Label label8;
        private TextBox txtSVetAdi;
        private Label label9;
        private RichTextBox rtxtTeshis;
        private RichTextBox rtxtTedavi;
        private Label label10;
        private RichTextBox rtxtNotlar;
        private Label label11;
        private GroupBox groupBox1;
        private Button btnAsiEkle;
        private GroupBox groupBox2;
        private Button btnSaglikEkle;
        private Button btnAsiSil;
        private Button btnAsiGuncelle;
        private Button btnKayitGuncelle;
        private Button btnKayitSil;
        private Button btnMenu;
    }
}