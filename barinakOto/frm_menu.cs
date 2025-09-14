using barinakOto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barinakOto
{
    public partial class frm_menu : Form
    {
        private readonly HayvanSahiplendirmeDbContext _context;
        private readonly Personeller _loggedInUser;


        public frm_menu(HayvanSahiplendirmeDbContext context, Personeller loggedInUser)
        {
            InitializeComponent();
            _context = context;
            _loggedInUser = loggedInUser;

        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Hoş Geldiniz, {_loggedInUser.AdSoyad} ({_loggedInUser.Gorev})";



            ApplyRoleBasedAccess();

            getAnimals();

        }

        private void ApplyRoleBasedAccess()
        {
            btnGonullu.Enabled = false;
            btnHayvanlar.Enabled = false;
            btnPersonel.Enabled = false;
            btnSaglik.Enabled = false;
            btnSahiplendirme.Enabled = false;





            switch (_loggedInUser.Gorev.ToLower())
            {
                case "yönetici":
                    btnGonullu.Enabled = true;
                    btnHayvanlar.Enabled = true;
                    btnPersonel.Enabled = true;
                    btnSaglik.Enabled = true;
                    btnSahiplendirme.Enabled = true;
                    break;

                case "bakıcı":

                    btnHayvanlar.Enabled = true;

                    break;

                case "veteriner":

                    btnSaglik.Enabled = true;
                    btnHayvanlar.Enabled = true;

                    break;

                default:
                    btnGonullu.Enabled = false;
                    btnHayvanlar.Enabled = false;
                    btnPersonel.Enabled = false;
                    btnSaglik.Enabled = false;
                    btnSahiplendirme.Enabled = false;
                    break;
            }
        }

        private void getAnimals()
        {

            try
            {
                int toplamHayvanSayisi = _context.Hayvanlars.Count();
                if (toplamHayvanSayisi > 0)
                {
                    lblBil1.Text = $"HAYVANLARIMIZ \n\n {toplamHayvanSayisi}";
                }
                else
                {
                    lblBil1.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hayvan sayıları alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                int sahiplenilenHayvanSayisi = _context.Hayvanlars.Count(h => h.SahiplenildiMi == true);
                if (sahiplenilenHayvanSayisi > 0)
                {
                    lblBil2.Text = $"SAHİPLENİLEN HAYVANLARIMIZ \n\n {sahiplenilenHayvanSayisi}";
                }
                else
                {
                    lblBil2.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hayvan sayıları alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHayvanlar_Click(object sender, EventArgs e)
        {

            frm_animals animals = new frm_animals(_context, _loggedInUser);
            this.Hide();
            animals.Show();
        }

        private void btnSaglik_Click(object sender, EventArgs e)
        {
            frm_veteriner veteriner = new frm_veteriner(_context, _loggedInUser);
            this.Hide();
            veteriner.Show();
        }

        private void btnGonullu_Click(object sender, EventArgs e)
        {
            frm_gonulluler gonulluler = new frm_gonulluler(_context, _loggedInUser);
            this.Hide();
            gonulluler.Show();
        }

        private void btnSahiplendirme_Click(object sender, EventArgs e)
        {
            frm_sahiplenen sahiplenen = new frm_sahiplenen(_context, _loggedInUser);
            this.Hide();
            sahiplenen.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login(_context);
            this.Hide();
            login.Show();
        }

        private void frm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            frm_login cikis = new frm_login(_context);
            this.Hide();
            cikis.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            frm_personel personel =new frm_personel(_context,_loggedInUser);
            this.Hide(); personel.Show();
        }
    }
}





  
