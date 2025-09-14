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
    public partial class frm_sahiplenen : Form
    {
        private readonly HayvanSahiplendirmeDbContext _context;
        private readonly Personeller _loggedInUser;
        private int _secilenSahiplenmeId = 0;
        public frm_sahiplenen(HayvanSahiplendirmeDbContext context, Personeller loggedInUser)
        {
            InitializeComponent();
            _context = context;
            PopulateComboboxes(); // Form yüklendiğinde ComboBox'ları doldur
            LoadData();
            _loggedInUser = loggedInUser;
        }

        private void PopulateComboboxes()
        {
            try
            {
                // Sahiplenenler ComboBox'ını doldur
                var sahiplenenler = _context.Sahiplenenlers.ToList();
                cmbSahiplenen.DataSource = sahiplenenler;
                cmbSahiplenen.DisplayMember = "AdSoyad"; 
                cmbSahiplenen.ValueMember = "Id";

                var sahiplenilmemisHayvanlar = _context.Hayvanlars
                                                      .Where(h => (bool)h.SahiplenildiMi == false).ToList();
                cmbHayvan.DataSource = sahiplenilmemisHayvanlar;
                cmbHayvan.DisplayMember = "Ad"; 
                cmbHayvan.ValueMember = "Id";
                cmbHayvan.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ComboBox verileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                var sahiplenmeler = _context.Sahiplenmelers
                                            .Include(s => s.Hayvan)
                                            .Include(s => s.Sahiplenen)
                                            .Select(s => new
                                            {
                                                s.Id,
                                                SahiplenenAdSoyad = s.Sahiplenen.AdSoyad,
                                                HayvanAd = s.Hayvan.Ad,
                                                s.SahiplenmeTarihi,
                                                s.Notlar,
                                                s.SahiplenenId,
                                                s.HayvanId
                                            })
                                            .ToList();

                dgvSahiplenmeler.DataSource = sahiplenmeler;
                dgvSahiplenmeler.Columns["Id"].Visible = false;
                dgvSahiplenmeler.Columns["SahiplenenId"].Visible = false;
                dgvSahiplenmeler.Columns["HayvanId"].Visible = false;

                dgvSahiplenmeler.Columns["SahiplenenAdSoyad"].HeaderText = "Sahiplenen";
                dgvSahiplenmeler.Columns["HayvanAd"].HeaderText = "Hayvan";
                dgvSahiplenmeler.Columns["SahiplenmeTarihi"].HeaderText = "Sahiplenme Tarihi";
                dgvSahiplenmeler.Columns["Notlar"].HeaderText = "Notlar";

                dgvSahiplenmeler.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahiplenme verileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbSahiplenen.SelectedValue == null ||
                    cmbHayvan.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen tüm gerekli alanları doldurun: Sahiplenen, Hayvan.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                var hayvanId = (int)cmbHayvan.SelectedValue;
                var hayvan = _context.Hayvanlars.Find(hayvanId);
                if (hayvan != null && (bool)hayvan.SahiplenildiMi)
                {
                    MessageBox.Show("Bu hayvan zaten sahiplenilmiştir. Lütfen başka bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var yeniSahiplenme = new Sahiplenmeler
                {
                    SahiplenenId = (int)cmbSahiplenen.SelectedValue,
                    HayvanId = (int)cmbHayvan.SelectedValue,
                    SahiplenmeTarihi = dtpSahiplenmeTarihi.Value,
                    Notlar = rtxtNotlar.Text
                };

                _context.Sahiplenmelers.Add(yeniSahiplenme);

                
                if (hayvan != null)
                {
                    hayvan.SahiplenildiMi = true;
                     //_context.Hayvanlars.Update(hayvan); 
                }

                _context.SaveChanges();
                MessageBox.Show("Sahiplenme kaydı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                PopulateComboboxes(); 
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahiplenme kaydı eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenSahiplenmeId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir sahiplenme kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (cmbSahiplenen.SelectedValue == null ||
                    cmbHayvan.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen tüm gerekli alanları doldurun: Sahiplenen, Hayvan, Sözleşme Durumu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var sahiplenme = _context.Sahiplenmelers.Find(_secilenSahiplenmeId);
                if (sahiplenme != null)
                {
                    
                    var eskiHayvanId = sahiplenme.HayvanId;
                    var yeniHayvanId = (int)cmbHayvan.SelectedValue;

                    if (eskiHayvanId != yeniHayvanId)
                    {
                        var eskiHayvan = _context.Hayvanlars.Find(eskiHayvanId);
                        if (eskiHayvan != null)
                        {
                            eskiHayvan.SahiplenildiMi = false;
                        }

                        
                        var yeniHayvan = _context.Hayvanlars.Find(yeniHayvanId);
                        if (yeniHayvan != null && (bool)yeniHayvan.SahiplenildiMi)
                        {
                            MessageBox.Show("Seçilen yeni hayvan zaten sahiplenilmiştir. Lütfen başka bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            
                            if (eskiHayvan != null) eskiHayvan.SahiplenildiMi = true;
                            return;
                        }
                        if (yeniHayvan != null)
                        {
                            yeniHayvan.SahiplenildiMi = true;
                        }
                    }

                    sahiplenme.SahiplenenId = (int)cmbSahiplenen.SelectedValue;
                    sahiplenme.HayvanId = (int)cmbHayvan.SelectedValue;
                    sahiplenme.SahiplenmeTarihi = dtpSahiplenmeTarihi.Value;
                    sahiplenme.Notlar = rtxtNotlar.Text;

                    _context.SaveChanges();
                    MessageBox.Show("Sahiplenme kaydı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    PopulateComboboxes(); 
                    LoadData(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahiplenme kaydı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_secilenSahiplenmeId == 0)
            {
                MessageBox.Show("Lütfen silinecek bir sahiplenme kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçilen sahiplenme kaydını silmek istediğinize emin misiniz? Bu işlem hayvanın sahiplenme durumunu değiştirecektir.", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var sahiplenme = _context.Sahiplenmelers.Find(_secilenSahiplenmeId);
                    if (sahiplenme != null)
                    {
                        
                        var hayvan = _context.Hayvanlars.Find(sahiplenme.HayvanId);
                        if (hayvan != null)
                        {
                            hayvan.SahiplenildiMi = false;
                        }

                        _context.Sahiplenmelers.Remove(sahiplenme);
                        _context.SaveChanges();
                        MessageBox.Show("Sahiplenme kaydı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        PopulateComboboxes(); 
                        LoadData(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sahiplenme kaydı silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvSahiplenmeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSahiplenmeler.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                DataGridViewRow row = dgvSahiplenmeler.Rows[e.RowIndex];
                _secilenSahiplenmeId = Convert.ToInt32(row.Cells["Id"].Value);

               
                cmbSahiplenen.SelectedValue = Convert.ToInt32(row.Cells["SahiplenenId"].Value);
                cmbHayvan.SelectedValue = Convert.ToInt32(row.Cells["HayvanId"].Value);

                dtpSahiplenmeTarihi.Value = Convert.ToDateTime(row.Cells["SahiplenmeTarihi"].Value);
                rtxtNotlar.Text = row.Cells["Notlar"].Value?.ToString();
            }
            else
            {
                _secilenSahiplenmeId = 0;
                ClearForm();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _secilenSahiplenmeId = 0;
            cmbSahiplenen.SelectedIndex = -1;
            cmbHayvan.SelectedIndex = -1;
            dtpSahiplenmeTarihi.Value = DateTime.Now;
            rtxtNotlar.Clear();
        }

        private void frm_sahiplenen_Load(object sender, EventArgs e)
        {
            dtpSahiplenmeTarihi.Value = DateTime.Now;
            lblWelcome.Text = $"Hoş Geldiniz, {_loggedInUser.AdSoyad} ({_loggedInUser.Gorev})";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu(_context, _loggedInUser);
            this.Hide();
            menu.Show();
        }


    }
}
