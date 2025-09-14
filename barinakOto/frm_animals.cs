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
    public partial class frm_animals : Form
    {
        private HayvanSahiplendirmeDbContext _context;
        private readonly Personeller _loggedInUser;
        private int _secilenHayvanId = 0;
        public frm_animals(HayvanSahiplendirmeDbContext context, Personeller loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            _context = context;

            LoadData();

            PopulateBarinaklarComboBox();
            Cinsiyet();
        }

        private void LoadData()
        {
            try
            {
                
                var hayvanlar = _context.Hayvanlars
                                        .Include(h => h.Barinak)
                                        .Select(h => new
                                        {
                                            h.Id,
                                            h.Ad,
                                            h.Tur,
                                            h.Cins,
                                            h.Yas,
                                            h.Cinsiyet,
                                            BarinakAdi = h.Barinak.Ad,
                                            h.Aciklama,
                                            h.SahiplenildiMi,
                                            h.KayitTarihi
                                        })
                                        .ToList();

                dgvHayvanlar.DataSource = hayvanlar;
                dgvHayvanlar.Columns["Id"].Visible = false;
                dgvHayvanlar.Columns["KayitTarihi"].Visible = false;
                dgvHayvanlar.Columns["SahiplenildiMi"].Visible = false;
                dgvHayvanlar.Columns["BarinakAdi"].HeaderText = "Barınak Adı";

                dgvHayvanlar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateBarinaklarComboBox()
        {
            try
            {
                var barinaklar = _context.Barinaklars.ToList();
                cmbBarinak.DataSource = barinaklar;
                cmbBarinak.DisplayMember = "Ad"; 
                cmbBarinak.ValueMember = "Id";   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Barınaklar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cinsiyet()
        {
            try
            {
                var hayvanlar = _context.Hayvanlars.ToList();
                cmbCinsiyet.DataSource = hayvanlar;
                cmbCinsiyet.DisplayMember = "Cinsiyet"; 
                cmbCinsiyet.ValueMember = "Id";   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Barınaklar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

               
                if (string.IsNullOrWhiteSpace(textAd.Text) ||
                    string.IsNullOrWhiteSpace(txtTur.Text) ||
                    cmbBarinak.SelectedValue == null)
                {
                    MessageBox.Show("Ad, Tür ve Barınak alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var yeniHayvan = new Hayvanlar
                    {
                        Ad = textAd.Text,
                        Tur = txtTur.Text,
                        Cins = txtCins.Text,
                        Yas = (int)numYas.Value,
                        Cinsiyet = cmbCinsiyet.Text,
                        Aciklama = rtxtAciklama.Text,
                        BarinakId = (int)cmbBarinak.SelectedValue, 
                        SahiplenildiMi = false, 
                        KayitTarihi = DateTime.Now
                    };

                    _context.Hayvanlars.Add(yeniHayvan);
                    _context.SaveChanges();
                    MessageBox.Show("Hayvan başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearForm()
        {
            _secilenHayvanId = 0;
            textAd.Clear();
            txtTur.Clear(); 
            txtCins.Clear();
            numYas.Value = 0;
            cmbCinsiyet.SelectedIndex = -1; 
            cmbBarinak.SelectedIndex = -1; 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenHayvanId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                if (string.IsNullOrWhiteSpace(textAd.Text) ||
                    string.IsNullOrWhiteSpace(txtTur.Text) ||
                    cmbBarinak.SelectedValue == null)
                {
                    MessageBox.Show("Ad, Tür ve Barınak alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var hayvan = _context.Hayvanlars.Find(_secilenHayvanId);
                if (hayvan != null)
                {
                    hayvan.Ad = textAd.Text;
                    hayvan.Tur = txtTur.Text;
                    hayvan.Cins = txtCins.Text;
                    hayvan.Yas = (int)numYas.Value;
                    hayvan.Cinsiyet = cmbCinsiyet.Text;
                    hayvan.Aciklama = rtxtAciklama.Text;
                    hayvan.BarinakId = (int)cmbBarinak.SelectedValue; 

                    _context.SaveChanges();
                    MessageBox.Show("Hayvan başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHayvanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvHayvanlar.Rows[e.RowIndex];
            _secilenHayvanId = (int)row.Cells["Id"].Value;

            textAd.Text = row.Cells["Ad"].Value?.ToString();
            txtTur.Text = row.Cells["Tur"].Value?.ToString();
            txtCins.Text = row.Cells["Cins"].Value?.ToString();
            numYas.Value = Convert.ToInt32(row.Cells["Yas"].Value);
            cmbCinsiyet.Text = row.Cells["Cinsiyet"].Value?.ToString();
            rtxtAciklama.Text = row.Cells["Aciklama"].Value?.ToString();

            
            string barinakAdi = row.Cells["BarinakAdi"].Value?.ToString();
            if (!string.IsNullOrEmpty(barinakAdi))
            {
                
                var selectedBarinak = (cmbBarinak.DataSource as System.Collections.Generic.List<Barinaklar>)
                                        .FirstOrDefault(b => b.Ad == barinakAdi);
                if (selectedBarinak != null)
                {
                    cmbBarinak.SelectedValue = selectedBarinak.Id;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_secilenHayvanId == 0)
            {
                MessageBox.Show("Lütfen silinecek bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçilen hayvanı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var hayvan = _context.Hayvanlars.Find(_secilenHayvanId);
                    if (hayvan != null)
                    {

                        
                        if ((bool)hayvan.SahiplenildiMi)
                        {
                            MessageBox.Show("Bu hayvan sahiplenildiği için silinemez. Önce sahiplenme kaydını kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        _context.Hayvanlars.Remove(hayvan);
                        _context.SaveChanges();
                        MessageBox.Show("Hayvan başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadData(); 
                    }
                }
                catch (DbUpdateException dbEx) 
                {
                   
                    if (dbEx.InnerException != null && dbEx.InnerException.Message.Contains("FK_Sahiplenmeler_Hayvanlar_HayvanId"))
                    {
                        MessageBox.Show("Bu hayvanın bir sahiplenme kaydı bulunmaktadır. Silinemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı işlemi sırasında bir hata oluştu: " + dbEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hayvan silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu(_context, _loggedInUser);
            this.Hide();
            menu.Show();

        }

        private void frm_animals_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Hoş Geldiniz, {_loggedInUser.AdSoyad} ({_loggedInUser.Gorev})";
        }
    }
}


