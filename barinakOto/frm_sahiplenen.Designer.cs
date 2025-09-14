namespace barinakOto
{
    partial class frm_sahiplenen
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
            dgvSahiplenmeler = new DataGridView();
            label1 = new Label();
            cmbSahiplenen = new ComboBox();
            cmbHayvan = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtpSahiplenmeTarihi = new DateTimePicker();
            label4 = new Label();
            rtxtNotlar = new RichTextBox();
            groupBox1 = new GroupBox();
            btnMenu = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSahiplenmeler).BeginInit();
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
            panel1.Size = new Size(1271, 125);
            panel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWelcome.Location = new Point(3, 37);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(418, 36);
            lblWelcome.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pets;
            pictureBox1.Location = new Point(1076, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvSahiplenmeler
            // 
            dgvSahiplenmeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSahiplenmeler.Dock = DockStyle.Bottom;
            dgvSahiplenmeler.Location = new Point(0, 446);
            dgvSahiplenmeler.Name = "dgvSahiplenmeler";
            dgvSahiplenmeler.RowHeadersWidth = 51;
            dgvSahiplenmeler.Size = new Size(1271, 263);
            dgvSahiplenmeler.TabIndex = 1;
            dgvSahiplenmeler.CellClick += dgvSahiplenmeler_CellClick;
            // 
            // label1
            // 
            label1.Location = new Point(35, 152);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 2;
            label1.Text = "Sahiplenen Kişi";
            // 
            // cmbSahiplenen
            // 
            cmbSahiplenen.FormattingEnabled = true;
            cmbSahiplenen.Location = new Point(35, 179);
            cmbSahiplenen.Name = "cmbSahiplenen";
            cmbSahiplenen.Size = new Size(151, 28);
            cmbSahiplenen.TabIndex = 3;
            // 
            // cmbHayvan
            // 
            cmbHayvan.FormattingEnabled = true;
            cmbHayvan.Location = new Point(239, 179);
            cmbHayvan.Name = "cmbHayvan";
            cmbHayvan.Size = new Size(149, 28);
            cmbHayvan.TabIndex = 5;
            // 
            // label2
            // 
            label2.Location = new Point(239, 152);
            label2.Name = "label2";
            label2.Size = new Size(149, 24);
            label2.TabIndex = 4;
            label2.Text = "Sahiplenilen Hayvan";
            // 
            // label3
            // 
            label3.Location = new Point(35, 247);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 6;
            label3.Text = "Sahiplenme Tarihi";
            // 
            // dtpSahiplenmeTarihi
            // 
            dtpSahiplenmeTarihi.Location = new Point(35, 274);
            dtpSahiplenmeTarihi.Name = "dtpSahiplenmeTarihi";
            dtpSahiplenmeTarihi.Size = new Size(232, 27);
            dtpSahiplenmeTarihi.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(37, 321);
            label4.Name = "label4";
            label4.Size = new Size(149, 24);
            label4.TabIndex = 8;
            label4.Text = "Notlar";
            // 
            // rtxtNotlar
            // 
            rtxtNotlar.Location = new Point(35, 348);
            rtxtNotlar.Name = "rtxtNotlar";
            rtxtNotlar.Size = new Size(333, 76);
            rtxtNotlar.TabIndex = 9;
            rtxtNotlar.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(1021, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 321);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ButtonShadow;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(27, 237);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(211, 29);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "MENÜ";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.ButtonShadow;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(27, 185);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(211, 29);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonShadow;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(27, 136);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(211, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL\r\n\r\n";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonShadow;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(27, 90);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(211, 29);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonShadow;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Location = new Point(27, 41);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(211, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // frm_sahiplenen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1271, 709);
            Controls.Add(groupBox1);
            Controls.Add(rtxtNotlar);
            Controls.Add(label4);
            Controls.Add(dtpSahiplenmeTarihi);
            Controls.Add(label3);
            Controls.Add(cmbHayvan);
            Controls.Add(label2);
            Controls.Add(cmbSahiplenen);
            Controls.Add(label1);
            Controls.Add(dgvSahiplenmeler);
            Controls.Add(panel1);
            Name = "frm_sahiplenen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sahiplenme";
            Load += frm_sahiplenen_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSahiplenmeler).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblWelcome;
        private DataGridView dgvSahiplenmeler;
        private Label label1;
        private ComboBox cmbSahiplenen;
        private ComboBox cmbHayvan;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpSahiplenmeTarihi;
        private Label label4;
        private RichTextBox rtxtNotlar;
        private GroupBox groupBox1;
        private Button btnMenu;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
    }
}