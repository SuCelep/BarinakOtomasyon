using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;



namespace barinakOto
{
    public partial class frm_login : Form
    {   
        private readonly HayvanSahiplendirmeDbContext _context;
        


        public frm_login(HayvanSahiplendirmeDbContext context)
        {
            InitializeComponent();
            _context = context;
            // Yönetici kullanýcýsýnýn 'admin' , þifresi '1'
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKadi.Text;
            string girilenSifre = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(girilenSifre))
            {
                lblHataMesaji.Text = "Kullanýcý adý ve þifre boþ býrakýlamaz.";
                lblHataMesaji.Visible = true;
                return;
            }

            try
            {
                
                var personel = _context.Personellers.FirstOrDefault(p => p.KullaniciAdi == kullaniciAdi);

                if (personel != null)
                {
                    
                    string girilenSifreHash = HashPassword(girilenSifre);

                    
                    if (personel.SifreHash == girilenSifreHash)
                    {
                        MessageBox.Show("Giriþ baþarýlý! Hoþ geldiniz, " + personel.AdSoyad, "Baþarýlý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frm_menu menu= new frm_menu(_context,personel);
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        lblHataMesaji.Text = "Kullanýcý adý veya þifre hatalý.";
                        lblHataMesaji.Visible = true;
                    }
                }
                else
                {
                    lblHataMesaji.Text = "Kullanýcý adý veya þifre hatalý.";
                    lblHataMesaji.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriþ sýrasýnda bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblHataMesaji.Text = "Bir hata oluþtu. Lütfen tekrar deneyin.";
                lblHataMesaji.Visible = true;
            }
        }  }
}
