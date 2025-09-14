namespace barinakOto
{
    partial class frm_animals
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
            dgvHayvanlar = new DataGridView();
            groupBox1 = new GroupBox();
            btnMenu = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            cmbBarinak = new ComboBox();
            textAd = new TextBox();
            txtTur = new TextBox();
            txtCins = new TextBox();
            cmbCinsiyet = new ComboBox();
            numYas = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            rtxtAciklama = new RichTextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvHayvanlar
            // 
            dgvHayvanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHayvanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHayvanlar.Dock = DockStyle.Bottom;
            dgvHayvanlar.Location = new Point(0, 364);
            dgvHayvanlar.Name = "dgvHayvanlar";
            dgvHayvanlar.RowHeadersWidth = 51;
            dgvHayvanlar.Size = new Size(1373, 334);
            dgvHayvanlar.TabIndex = 0;
            dgvHayvanlar.CellClick += dgvHayvanlar_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(1100, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 279);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlemler";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ButtonShadow;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(19, 232);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(212, 33);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "MENÜ";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.ButtonShadow;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(19, 179);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(212, 33);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonShadow;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(19, 129);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(212, 33);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonShadow;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(19, 79);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(212, 33);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonShadow;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Location = new Point(19, 23);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(212, 33);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbBarinak
            // 
            cmbBarinak.FormattingEnabled = true;
            cmbBarinak.Location = new Point(273, 220);
            cmbBarinak.Name = "cmbBarinak";
            cmbBarinak.Size = new Size(250, 28);
            cmbBarinak.TabIndex = 2;
            // 
            // textAd
            // 
            textAd.Location = new Point(12, 164);
            textAd.Name = "textAd";
            textAd.Size = new Size(239, 27);
            textAd.TabIndex = 3;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(12, 221);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(239, 27);
            txtTur.TabIndex = 3;
            // 
            // txtCins
            // 
            txtCins.Location = new Point(12, 288);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(239, 27);
            txtCins.TabIndex = 3;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(273, 164);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(185, 28);
            cmbCinsiyet.TabIndex = 2;
            // 
            // numYas
            // 
            numYas.Location = new Point(273, 288);
            numYas.Name = "numYas";
            numYas.Size = new Size(239, 27);
            numYas.TabIndex = 4;
            // 
            // label1
            // 
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 5;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.Location = new Point(12, 194);
            label2.Name = "label2";
            label2.Size = new Size(214, 20);
            label2.TabIndex = 5;
            label2.Text = "Tür";
            // 
            // label3
            // 
            label3.Location = new Point(12, 264);
            label3.Name = "label3";
            label3.Size = new Size(214, 20);
            label3.TabIndex = 5;
            label3.Text = "Cins";
            // 
            // label4
            // 
            label4.Location = new Point(273, 262);
            label4.Name = "label4";
            label4.Size = new Size(224, 24);
            label4.TabIndex = 5;
            label4.Text = "Yaş";
            // 
            // label5
            // 
            label5.Location = new Point(592, 164);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 5;
            label5.Text = "Açıklama";
            // 
            // label6
            // 
            label6.Location = new Point(273, 135);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 5;
            label6.Text = "Cinsiyet";
            // 
            // label7
            // 
            label7.Location = new Point(273, 195);
            label7.Name = "label7";
            label7.Size = new Size(189, 20);
            label7.TabIndex = 5;
            label7.Text = "Barınak";
            // 
            // rtxtAciklama
            // 
            rtxtAciklama.Location = new Point(592, 192);
            rtxtAciklama.Name = "rtxtAciklama";
            rtxtAciklama.Size = new Size(273, 117);
            rtxtAciklama.TabIndex = 6;
            rtxtAciklama.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1373, 85);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pets;
            pictureBox1.Location = new Point(1160, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWelcome.Location = new Point(0, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(462, 49);
            lblWelcome.TabIndex = 0;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_animals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1373, 698);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(rtxtAciklama);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numYas);
            Controls.Add(txtCins);
            Controls.Add(txtTur);
            Controls.Add(textAd);
            Controls.Add(cmbCinsiyet);
            Controls.Add(cmbBarinak);
            Controls.Add(dgvHayvanlar);
            Name = "frm_animals";
            ShowIcon = false;
            Text = "Hayvanlarımız";
            Load += frm_animals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numYas).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHayvanlar;
        private GroupBox groupBox1;
        private ComboBox cmbBarinak;
        private Button btnEkle;
        private TextBox textAd;
        private TextBox txtTur;
        private TextBox txtCins;
        private ComboBox cmbCinsiyet;
        private NumericUpDown numYas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox rtxtAciklama;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private Button btnMenu;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblWelcome;
    }
}