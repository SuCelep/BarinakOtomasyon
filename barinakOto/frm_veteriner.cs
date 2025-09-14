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
    public partial class frm_veteriner : Form
    {
        private readonly HayvanSahiplendirmeDbContext _context;
        private readonly Personeller _loggedInUser;
        private int _secilenHayvanId = 0;
        private int _secilenAsiId = 0; 
        private int _secilenSaglikKayitId = 0; 
        public frm_veteriner(HayvanSahiplendirmeDbContext context, Personeller loggedInUser)
        {
            InitializeComponent();
            _context = context;
            AnimalsComboBox();
            _loggedInUser = loggedInUser;
        }
        private void AnimalsComboBox()
        {
            try
            {
                var hayvanlar = _context.Hayvanlars.ToList();
                cmbHayvanSecimi.DataSource = hayvanlar;
                cmbHayvanSecimi.DisplayMember = "Ad"; 
                cmbHayvanSecimi.ValueMember = "Id";   
                cmbHayvanSecimi.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvanlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbHayvanSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHayvanSecimi.SelectedValue != null && cmbHayvanSecimi.SelectedValue is int)
            {
                _secilenHayvanId = (int)cmbHayvanSecimi.SelectedValue;
                LoadAsiData(_secilenHayvanId);
                LoadSaglikKayitlariData(_secilenHayvanId);
                ClearAsiForm();
                ClearSaglikKayitForm();
            }
            else
            {
                _secilenHayvanId = 0;
                dgvAsilar.DataSource = null; 
                dgvSaglikKayitlari.DataSource = null;
                ClearAsiForm();
                ClearSaglikKayitForm();
            }

        }

        private void LoadAsiData(int hayvanId)
        {
            try
            {
                var asilar = _context.Asilars
                                     .Where(a => a.HayvanId == hayvanId)
                                     .Select(a => new
                                     {
                                         a.Id,
                                         a.AsiAdi,
                                         a.AsiTarihi,
                                         a.SonrakiAsiTarihi,
                                         a.VeterinerAd
                                     })
                                     .ToList();
                dgvAsilar.DataSource = asilar;
                dgvAsilar.Columns["Id"].Visible = false;
                dgvAsilar.Columns["AsiAdi"].HeaderText = "Yapılan Aşı";
                dgvAsilar.Columns["AsiTarihi"].HeaderText = "Aşı Tarihi";
                dgvAsilar.Columns["SonrakiAsiTarihi"].HeaderText = "Sonraki Aşı";
                dgvAsilar.Columns["VeterinerAd"].HeaderText = "Veteriner";
                dgvAsilar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aşı verileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsiEkle_Click(object sender, EventArgs e)
        {
            if (_secilenHayvanId == 0)
            {
                MessageBox.Show("Lütfen önce bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAsiAdi.Text))
            {
                MessageBox.Show("Aşı adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var yeniAsi = new Asilar
                {
                    HayvanId = _secilenHayvanId,
                    AsiAdi = txtAsiAdi.Text,
                    AsiTarihi = dtpAsiTarihi.Value,
                    SonrakiAsiTarihi = dtpSonrakiAsiTarihi.Checked ? (DateTime?)dtpSonrakiAsiTarihi.Value : null, 
                    VeterinerAd = txtVetAdi.Text,
                };

                _context.Asilars.Add(yeniAsi);
                _context.SaveChanges();
                MessageBox.Show("Aşı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAsiForm();
                LoadAsiData(_secilenHayvanId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aşı eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ClearAsiForm()
        {
            _secilenAsiId = 0;
            txtAsiAdi.Clear();
            dtpAsiTarihi.Value = DateTime.Now;
            dtpSonrakiAsiTarihi.Value = DateTime.Now;
            dtpSonrakiAsiTarihi.Checked = false; 
            txtVetAdi.Clear();
        }

        private void btnAsiSil_Click(object sender, EventArgs e)
        {
            if (_secilenAsiId == 0)
            {
                MessageBox.Show("Lütfen silinecek bir aşı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçilen aşıyı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var asi = _context.Asilars.Find(_secilenAsiId);
                    if (asi != null)
                    {
                        _context.Asilars.Remove(asi);
                        _context.SaveChanges();
                        MessageBox.Show("Aşı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAsiForm();
                        LoadAsiData(_secilenHayvanId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aşı silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAsiGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenAsiId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir aşı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAsiAdi.Text))
            {
                MessageBox.Show("Aşı adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var asi = _context.Asilars.Find(_secilenAsiId);
                if (asi != null)
                {
                    asi.AsiAdi = txtAsiAdi.Text;
                    asi.AsiTarihi = dtpAsiTarihi.Value;
                    asi.SonrakiAsiTarihi = dtpSonrakiAsiTarihi.Checked ? (DateTime?)dtpSonrakiAsiTarihi.Value : null;
                    asi.VeterinerAd = txtVetAdi.Text;

                    _context.SaveChanges();
                    MessageBox.Show("Aşı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAsiForm();
                    LoadAsiData(_secilenHayvanId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aşı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAsilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAsilar.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                DataGridViewRow row = dgvAsilar.Rows[e.RowIndex];
                _secilenAsiId = Convert.ToInt32(row.Cells["Id"].Value);

                txtAsiAdi.Text = row.Cells["AsiAdi"].Value?.ToString();
                dtpAsiTarihi.Value = Convert.ToDateTime(row.Cells["AsiTarihi"].Value);

               
                if (row.Cells["SonrakiAsiTarihi"].Value != DBNull.Value && row.Cells["SonrakiAsiTarihi"].Value != null)
                {
                    dtpSonrakiAsiTarihi.Value = Convert.ToDateTime(row.Cells["SonrakiAsiTarihi"].Value);
                    dtpSonrakiAsiTarihi.Checked = true;
                }
                else
                {
                    dtpSonrakiAsiTarihi.Checked = false;
                    dtpSonrakiAsiTarihi.Value = DateTime.Now; 
                }
                txtVetAdi.Text = row.Cells["VeterinerAd"].Value?.ToString();
            }
            else
            {
                _secilenAsiId = 0; 
                ClearAsiForm();
            }
        }

        private void LoadSaglikKayitlariData(int hayvanId)
        {
            try
            {
                var saglikKayitlari = _context.SaglikKayitlaris
                                              .Where(sk => sk.HayvanId == hayvanId)
                                              .Select(sk => new
                                              {
                                                  sk.Id,
                                                  sk.KayitTarihi,
                                                  sk.Teshis,
                                                  sk.Tedavi,
                                                  sk.Notlar,
                                                  sk.VeterinerAd
                                              })
                                              .ToList();
                dgvSaglikKayitlari.DataSource = saglikKayitlari;
                dgvSaglikKayitlari.Columns["Id"].Visible = false;
                dgvSaglikKayitlari.Columns["Teshis"].HeaderText = "Teşhis";
                dgvSaglikKayitlari.Columns["VeterinerAd"].HeaderText = "Veteriner";
                dgvSaglikKayitlari.Columns["KayitTarihi"].HeaderText = "Kayıt Tarihi";
                dgvSaglikKayitlari.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sağlık kayıtları yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSaglikKayitForm()
        {
            _secilenSaglikKayitId = 0;
            rtxtTeshis.Clear();
            rtxtTedavi.Clear();
            rtxtNotlar.Clear();
            txtSVetAdi.Clear();
        }

        private void btnSaglikEkle_Click(object sender, EventArgs e)
        {
            if (_secilenHayvanId == 0)
            {
                MessageBox.Show("Lütfen önce bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(rtxtTeshis.Text))
            {
                MessageBox.Show("Teşhis boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var yeniKayit = new SaglikKayitlari
                {
                    HayvanId = _secilenHayvanId,
                    Teshis = rtxtTeshis.Text,
                    Tedavi = rtxtTedavi.Text,
                    Notlar = rtxtNotlar.Text,
                    VeterinerAd = txtSVetAdi.Text
                };

                _context.SaglikKayitlaris.Add(yeniKayit);
                _context.SaveChanges();
                MessageBox.Show("Sağlık kaydı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSaglikKayitForm();
                LoadSaglikKayitlariData(_secilenHayvanId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sağlık kaydı eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            if (_secilenSaglikKayitId == 0)
            {
                MessageBox.Show("Lütfen silinecek bir sağlık kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Seçilen sağlık kaydını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var kayit = _context.SaglikKayitlaris.Find(_secilenSaglikKayitId);
                    if (kayit != null)
                    {
                        _context.SaglikKayitlaris.Remove(kayit);
                        _context.SaveChanges();
                        MessageBox.Show("Sağlık kaydı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearSaglikKayitForm();
                        LoadSaglikKayitlariData(_secilenHayvanId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sağlık kaydı silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenSaglikKayitId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir sağlık kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(rtxtTeshis.Text))
            {
                MessageBox.Show("Teşhis boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var kayit = _context.SaglikKayitlaris.Find(_secilenSaglikKayitId);
                if (kayit != null)
                {
                    kayit.Teshis = rtxtTeshis.Text;
                    kayit.Tedavi = rtxtTedavi.Text;
                    kayit.Notlar = rtxtNotlar.Text;
                    kayit.VeterinerAd = txtSVetAdi.Text;

                    _context.SaveChanges();
                    MessageBox.Show("Sağlık kaydı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSaglikKayitForm();
                    LoadSaglikKayitlariData(_secilenHayvanId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sağlık kaydı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSaglikKayitlari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSaglikKayitlari.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                DataGridViewRow row = dgvSaglikKayitlari.Rows[e.RowIndex];
                _secilenSaglikKayitId = Convert.ToInt32(row.Cells["Id"].Value);
                rtxtTeshis.Text = row.Cells["Teshis"].Value?.ToString();
                rtxtTedavi.Text = row.Cells["Tedavi"].Value?.ToString();
                rtxtNotlar.Text = row.Cells["Notlar"].Value?.ToString();
                txtSVetAdi.Text = row.Cells["VeterinerAd"].Value?.ToString();
            }
            else
            {
                _secilenSaglikKayitId = 0;
                ClearSaglikKayitForm();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu(_context, _loggedInUser);
            this.Hide();
            menu.Show();

        }

        private void frm_veteriner_Load(object sender, EventArgs e)
        {
            

        }
    }
}
