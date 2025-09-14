namespace barinakOto
{
    partial class frm_menu
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
            lblWelcome = new Label();
            panel1 = new Panel();
            btnGonullu = new Button();
            btnSahiplendirme = new Button();
            btnSaglik = new Button();
            btnPersonel = new Button();
            btnHayvanlar = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblBil1 = new Label();
            lblBil2 = new Label();
            btnCikis = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = SystemColors.ScrollBar;
            lblWelcome.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(533, 33);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(518, 39);
            lblWelcome.TabIndex = 0;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(btnGonullu);
            panel1.Controls.Add(btnSahiplendirme);
            panel1.Controls.Add(btnSaglik);
            panel1.Controls.Add(btnPersonel);
            panel1.Controls.Add(btnHayvanlar);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 645);
            panel1.TabIndex = 1;
            // 
            // btnGonullu
            // 
            btnGonullu.BackColor = SystemColors.ButtonShadow;
            btnGonullu.FlatStyle = FlatStyle.Flat;
            btnGonullu.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGonullu.Location = new Point(23, 580);
            btnGonullu.Name = "btnGonullu";
            btnGonullu.Size = new Size(264, 46);
            btnGonullu.TabIndex = 5;
            btnGonullu.Text = "Gönüllülerimiz";
            btnGonullu.UseVisualStyleBackColor = false;
            btnGonullu.Click += btnGonullu_Click;
            // 
            // btnSahiplendirme
            // 
            btnSahiplendirme.BackColor = SystemColors.ButtonShadow;
            btnSahiplendirme.FlatStyle = FlatStyle.Flat;
            btnSahiplendirme.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSahiplendirme.Location = new Point(23, 491);
            btnSahiplendirme.Name = "btnSahiplendirme";
            btnSahiplendirme.Size = new Size(264, 48);
            btnSahiplendirme.TabIndex = 4;
            btnSahiplendirme.Text = "Sahiplendirme";
            btnSahiplendirme.UseVisualStyleBackColor = false;
            btnSahiplendirme.Click += btnSahiplendirme_Click;
            // 
            // btnSaglik
            // 
            btnSaglik.BackColor = SystemColors.ButtonShadow;
            btnSaglik.FlatStyle = FlatStyle.Flat;
            btnSaglik.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaglik.Location = new Point(23, 394);
            btnSaglik.Name = "btnSaglik";
            btnSaglik.Size = new Size(264, 48);
            btnSaglik.TabIndex = 3;
            btnSaglik.Text = "Veteriner İşlemleri\r\n";
            btnSaglik.UseVisualStyleBackColor = false;
            btnSaglik.Click += btnSaglik_Click;
            // 
            // btnPersonel
            // 
            btnPersonel.BackColor = SystemColors.ButtonShadow;
            btnPersonel.FlatStyle = FlatStyle.Flat;
            btnPersonel.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonel.Location = new Point(23, 302);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(264, 45);
            btnPersonel.TabIndex = 2;
            btnPersonel.Text = "Personel İşlemleri\r\n\r\n\r\n";
            btnPersonel.UseVisualStyleBackColor = false;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // btnHayvanlar
            // 
            btnHayvanlar.BackColor = SystemColors.ButtonShadow;
            btnHayvanlar.FlatStyle = FlatStyle.Flat;
            btnHayvanlar.Font = new Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHayvanlar.Location = new Point(23, 207);
            btnHayvanlar.Name = "btnHayvanlar";
            btnHayvanlar.Size = new Size(264, 46);
            btnHayvanlar.TabIndex = 1;
            btnHayvanlar.Text = "Hayvanlarımız";
            btnHayvanlar.UseVisualStyleBackColor = false;
            btnHayvanlar.Click += btnHayvanlar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GrayText;
            pictureBox1.BackgroundImage = Properties.Resources.people;
            pictureBox1.Image = Properties.Resources.pets;
            pictureBox1.Location = new Point(84, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(lblWelcome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(313, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 125);
            panel2.TabIndex = 2;
            // 
            // lblBil1
            // 
            lblBil1.BackColor = Color.IndianRed;
            lblBil1.Location = new Point(471, 244);
            lblBil1.Name = "lblBil1";
            lblBil1.Size = new Size(327, 235);
            lblBil1.TabIndex = 3;
            lblBil1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBil2
            // 
            lblBil2.BackColor = Color.DarkCyan;
            lblBil2.Location = new Point(877, 244);
            lblBil2.Name = "lblBil2";
            lblBil2.Size = new Size(327, 235);
            lblBil2.TabIndex = 4;
            lblBil2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = SystemColors.AppWorkspace;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Location = new Point(1274, 603);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 42);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çık";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click_1;
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1368, 645);
            Controls.Add(btnCikis);
            Controls.Add(lblBil2);
            Controls.Add(lblBil1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menü";
            FormClosed += frm_menu_FormClosed;
            Load += frm_menu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnHayvanlar;
        private Button btnPersonel;
        private Button btnSaglik;
        private Button btnSahiplendirme;
        private Button btnGonullu;
        private Label lblBil1;
        private Label lblBil2;
        private Button btnCikis;
    }
}