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

    public partial class frm_personel : Form
    {

        private readonly HayvanSahiplendirmeDbContext _context;
        private readonly Personeller _loggedInUser;
        private int _secilenPersonelId = 0;
        public frm_personel(HayvanSahiplendirmeDbContext context, Personeller loggedInUser)
        {
            InitializeComponent();
            _context = context;
            LoadData();
            txtSifre.UseSystemPasswordChar = true;
            _loggedInUser = loggedInUser;
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

        private void LoadData()
        {
            try
            {
                var personeller = _context.Personellers
                                             .Select(p => new
                                             {
                                                 p.Id,
                                                 p.AdSoyad,
                                                 p.Gorev,
                                                 p.Telefon,
                                                 p.Eposta,
                                                 p.KullaniciAdi,
                                             })
                                             .ToList();

                dgvPersonel.DataSource = personeller;
                dgvPersonel.Columns["Id"].Visible = false;

                
                dgvPersonel.Columns["AdSoyad"].HeaderText = "Adı";
                dgvPersonel.Columns["Gorev"].HeaderText = "Görev";
                dgvPersonel.Columns["Telefon"].HeaderText = "Telefon";
                dgvPersonel.Columns["Eposta"].HeaderText = "E-posta";
                dgvPersonel.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı"; 
                dgvPersonel.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel verileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                    string.IsNullOrWhiteSpace(txtGorev.Text) ||
                    string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || 
                    string.IsNullOrWhiteSpace(txtSifre.Text))        
                {
                    MessageBox.Show("Ad, Soyad, Pozisyon, Kullanıcı Adı ve Şifre alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (_context.Personellers.Any(p => p.KullaniciAdi == txtKullaniciAdi.Text))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Lütfen farklı bir kullanıcı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var yeniPersonel = new Personeller
                {
                    AdSoyad = txtAdSoyad.Text,
                    Gorev = txtGorev.Text,
                    Telefon = txtTel.Text,
                    Eposta = txtPosta.Text,
                    KullaniciAdi = txtKullaniciAdi.Text,
                    SifreHash = HashPassword(txtSifre.Text) 
                };

                _context.Personellers.Add(yeniPersonel);
                _context.SaveChanges();
                MessageBox.Show("Personel başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (DbUpdateException dbEx) 
            {
                string errorMessage = "Veritabanı işlemi sırasında bir hata oluştu.";

                if (dbEx.InnerException != null)
                {
                    
                    string innerMessage = dbEx.InnerException.Message;

                    
                    if (innerMessage.Contains("Cannot insert duplicate key") || innerMessage.Contains("Violation of UNIQUE KEY constraint"))
                    {
                        errorMessage = "Bu kullanıcı adı zaten mevcut. Lütfen farklı bir kullanıcı adı deneyin.";
                    }
                   
                    else
                    {
                        
                        errorMessage += "\nDetay: " + innerMessage;
                    }
                }
                else
                {
                    
                    errorMessage += "\nDetay: " + dbEx.Message;
                }

                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenPersonelId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                    string.IsNullOrWhiteSpace(txtGorev.Text) ||
                    string.IsNullOrWhiteSpace(txtKullaniciAdi.Text)) 
                {
                    MessageBox.Show("Ad, Soyad, Pozisyon ve Kullanıcı Adı alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var personel = _context.Personellers.Find(_secilenPersonelId);
                if (personel != null)
                {
                    
                    if (personel.KullaniciAdi != txtKullaniciAdi.Text && _context.Personellers.Any(p => p.KullaniciAdi == txtKullaniciAdi.Text && p.Id != _secilenPersonelId))
                    {
                        MessageBox.Show("Bu kullanıcı adı başka bir personel tarafından kullanılıyor. Lütfen farklı bir kullanıcı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    personel.AdSoyad = txtAdSoyad.Text;
                    personel.Gorev = txtGorev.Text;
                    personel.Telefon = txtTel.Text;
                    personel.Eposta = txtPosta.Text;
                    personel.KullaniciAdi = txtKullaniciAdi.Text;

                    
                    if (!string.IsNullOrWhiteSpace(txtSifre.Text))
                    {
                        personel.SifreHash = HashPassword(txtSifre.Text);
                    }

                    _context.SaveChanges();
                    MessageBox.Show("Personel başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }
            }
            catch (DbUpdateException dbEx)
            {
                if (dbEx.InnerException != null && (dbEx.InnerException.Message.Contains("Cannot insert duplicate key") || dbEx.InnerException.Message.Contains("Violation of UNIQUE KEY constraint")))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen farklı bir kullanıcı adı deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Veritabanı işlemi sırasında bir hata oluştu: " + dbEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_secilenPersonelId == 0)
            {
                MessageBox.Show("Lütfen silinecek bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçilen personeli silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var personel = _context.Personellers.Find(_secilenPersonelId);
                    if (personel != null)
                    {
                        _context.Personellers.Remove(personel);
                        _context.SaveChanges();
                        MessageBox.Show("Personel başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadData();
                    }
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show("Bu personel, başka kayıtlarda kullanıldığı için silinemez. Önce ilgili kayıtları silin veya güncelleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPersonel.Rows[e.RowIndex];

                if (row.Cells["Id"].Value != null)
                {
                    _secilenPersonelId = Convert.ToInt32(row.Cells["Id"].Value);
                }
                else
                {
                    _secilenPersonelId = 0;
                    ClearForm();
                    return;
                }

                txtAdSoyad.Text = row.Cells["AdSoyad"].Value?.ToString();
                txtGorev.Text = row.Cells["Gorev"].Value?.ToString();
                txtTel.Text = row.Cells["Telefon"].Value?.ToString();
                txtPosta.Text = row.Cells["Eposta"].Value?.ToString();


                txtKullaniciAdi.Text = row.Cells["KullaniciAdi"].Value?.ToString();
                txtSifre.Text = ""; 
            }
            else
            {
                _secilenPersonelId = 0;
                ClearForm();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _secilenPersonelId = 0;
            txtAdSoyad.Clear();
            txtGorev.Clear();
            txtTel.Clear();
            txtPosta.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void frm_personel_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Hoş Geldiniz, {_loggedInUser.AdSoyad} ({_loggedInUser.Gorev})";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frm_menu menu= new frm_menu(_context,_loggedInUser);
            this.Hide();
            menu.Show();
        }
    }
}
