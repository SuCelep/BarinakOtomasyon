using barinakOto.Models;
using System;
using System.Collections.Generic;
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


namespace barinakOto
{

    public partial class frm_gonulluler : Form
    {
        private readonly HayvanSahiplendirmeDbContext _context;
        private readonly Personeller _loggedInUser;
        private int _secilenSahiplenenId = 0;
        public frm_gonulluler(HayvanSahiplendirmeDbContext context, Personeller loggedInUser)
        {
            InitializeComponent();
            _context = context;
            LoadData();
            _loggedInUser = loggedInUser;
        }

        private void LoadData()
        {
            try
            {
                var sahiplenenler = _context.Sahiplenenlers
                                             .Select(s => new
                                             {
                                                 s.Id,
                                                 s.AdSoyad,
                                                 s.KimlikNo, 
                                                 s.Telefon,
                                                 s.Eposta,
                                                 s.Adres,

                                             })
                                             .ToList();

                dgvSahiplenenler.DataSource = sahiplenenler;
                dgvSahiplenenler.Columns["Id"].Visible = false;

                
                dgvSahiplenenler.Columns["AdSoyad"].HeaderText = "Ad Soyad";
                dgvSahiplenenler.Columns["KimlikNo"].HeaderText = "Kimlik No"; 
                dgvSahiplenenler.Columns["Telefon"].HeaderText = "Telefon No";
                dgvSahiplenenler.Columns["Eposta"].HeaderText = "E-posta";
                dgvSahiplenenler.Columns["Adres"].HeaderText = "Adres";

                dgvSahiplenenler.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahiplenen verileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtNum.Text) ||
                string.IsNullOrWhiteSpace(txtKimlikNo.Text)) 
            {
                MessageBox.Show("Ad, Soyad, Kimlik No ve Telefon alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                if (_context.Sahiplenenlers.Any(s => s.KimlikNo == txtKimlikNo.Text))
                {
                    MessageBox.Show("Bu Kimlik Numarası zaten kayıtlı. Lütfen farklı bir kimlik numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var yeniSahiplenen = new Sahiplenenler
                {
                    AdSoyad = txtAdSoyad.Text,
                    KimlikNo = txtKimlikNo.Text, 
                    Telefon = txtNum.Text,
                    Eposta = txtEposta.Text,
                    Adres = txtAdres.Text
                };

                _context.Sahiplenenlers.Add(yeniSahiplenen);
                _context.SaveChanges();
                MessageBox.Show("Sahiplenen başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (DbUpdateException dbEx) 
            {
                
                if (dbEx.InnerException != null && (dbEx.InnerException.Message.Contains("Cannot insert duplicate key") || dbEx.InnerException.Message.Contains("Violation of UNIQUE KEY constraint")))
                {
                    MessageBox.Show("Bu Kimlik Numarası zaten kayıtlı. Lütfen farklı bir kimlik numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Veritabanı işlemi sırasında bir hata oluştu: " + dbEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahiplenen eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            _secilenSahiplenenId = 0;
            txtAdSoyad.Clear();
            txtKimlikNo.Clear(); 
            txtNum.Clear();
            txtEposta.Clear();
            txtAdres.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenSahiplenenId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir sahiplenen seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                    string.IsNullOrWhiteSpace(txtNum.Text) ||
                    string.IsNullOrWhiteSpace(txtKimlikNo.Text)) 
                {
                    MessageBox.Show("Ad, Soyad, Kimlik No ve Telefon alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var sahiplenen = _context.Sahiplenenlers.Find(_secilenSahiplenenId);

                if (sahiplenen != null)
                {
                    
                    if (sahiplenen.KimlikNo != txtKimlikNo.Text && _context.Sahiplenenlers.Any(s => s.KimlikNo == txtKimlikNo.Text && s.Id != _secilenSahiplenenId))
                    {
                        MessageBox.Show("Bu Kimlik Numarası başka bir sahiplenen tarafından kullanılıyor. Lütfen farklı bir kimlik numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    sahiplenen.AdSoyad = txtAdSoyad.Text;
                    sahiplenen.KimlikNo = txtKimlikNo.Text; 
                    sahiplenen.Telefon = txtNum.Text;
                    sahiplenen.Eposta = txtEposta.Text;
                    sahiplenen.Adres = txtAdres.Text;

                    _context.SaveChanges();
                    MessageBox.Show("Sahiplenen başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }
            }
            catch (DbUpdateException dbEx) 
            {
                
                if (dbEx.InnerException != null && (dbEx.InnerException.Message.Contains("Cannot insert duplicate key") || dbEx.InnerException.Message.Contains("Violation of UNIQUE KEY constraint")))
                {
                    MessageBox.Show("Bu Kimlik Numarası başka bir sahiplenen tarafından kullanılıyor. Lütfen farklı bir kimlik numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Veritabanı işlemi sırasında bir hata oluştu: " + dbEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahiplenen güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_secilenSahiplenenId == 0)
            {
                MessageBox.Show("Lütfen silinecek bir sahiplenen seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçilen sahipleneni silmek istediğinize emin misiniz? Bu işlem, bu kişiye ait sahiplenme kayıtlarını etkileyebilir.", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var sahiplenen = _context.Sahiplenenlers.Find(_secilenSahiplenenId);
                    if (sahiplenen != null)
                    {
                        _context.Sahiplenenlers.Remove(sahiplenen);
                        _context.SaveChanges();
                        MessageBox.Show("Sahiplenen başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadData();
                    }
                }
                catch (DbUpdateException dbEx)
                {
                    if (dbEx.InnerException != null && dbEx.InnerException.Message.Contains("FK_Sahiplenmeler_Sahiplenenler_SahiplenenId"))
                    {
                        MessageBox.Show("Bu sahiplenenin aktif sahiplenme kayıtları bulunmaktadır. Silinemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı işlemi sırasında bir hata oluştu: " + dbEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sahiplenen silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void dgvSahiplenenler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSahiplenenler.Rows[e.RowIndex];

                if (row.Cells["Id"].Value != null)
                {
                    _secilenSahiplenenId = Convert.ToInt32(row.Cells["Id"].Value);
                }
                else
                {
                    _secilenSahiplenenId = 0;
                    ClearForm();
                    return;
                }

                txtAdSoyad.Text = row.Cells["AdSoyad"].Value?.ToString();
                txtKimlikNo.Text = row.Cells["KimlikNo"].Value?.ToString(); 
                txtNum.Text = row.Cells["Telefon"].Value?.ToString();
                txtEposta.Text = row.Cells["Eposta"].Value?.ToString();
                txtAdres.Text = row.Cells["Adres"].Value?.ToString();
            }
            else
            {
                _secilenSahiplenenId = 0;
                ClearForm();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu(_context, _loggedInUser);
            this.Hide();
            menu.Show();

        }

        private void frm_gonulluler_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Hoş Geldiniz, {_loggedInUser.AdSoyad} ({_loggedInUser.Gorev})";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
} 

