using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sikayet;

namespace Sikayet
{

    public partial class Form1 : Form
    {
        private MusteriSikayetEntities veritabani = new MusteriSikayetEntities();
        private List<Sikayet_Tablo> SilinenKayitlar { get; set; } = new List<Sikayet_Tablo>();
        private TextBox txtFotoDurum;
        private Button btnFotoSec;
        private byte[] fotoğrafBytes;
       
        public Form1()
        {
            InitializeComponent();
            
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
        }
        //YÜKLEME METHODU (PARAMETRE ADLARI BULUNUYOR)
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
         
            radioButtonIstekAlindi.Checked = true;
            ApplyDataGridViewStyle(dataGridView1);

            //PARAMETRELERİN DÜZENLENMESİ
            dataGridView1.Columns["Sikayet_Id"].HeaderText = "ID";  // Sikayet_Turu yerine Şikayet Türü
            dataGridView1.Columns["Sikayet_Turu"].HeaderText = "İstek Türü";  // Sikayet_Turu yerine Şikayet Türü
            dataGridView1.Columns["Firma_Adi"].HeaderText = "Firma Adı";  // Firma_Adi yerine Firma Adı
            dataGridView1.Columns["Firma_Personel"].HeaderText = "Firma Personeli";  // Firma_Personel yerine Firma Personeli
            dataGridView1.Columns["Sikayet_Aciklamasi"].HeaderText = "İstek Açıklaması";  // Sikayet_Aciklamasi yerine Şikayet Açıklaması
            dataGridView1.Columns["Tel_No"].HeaderText = "Telefon No";  // Tel_No yerine Telefon Numarası
            dataGridView1.Columns["Sirket_Eposta"].HeaderText = "Firma E-postası";  // Sirket_Eposta yerine Şirket E-posta
            dataGridView1.Columns["Cozum_Not"].HeaderText = "Çözüm Notu";  // Cozum_Not yerine Çözüm Notu
            dataGridView1.Columns["Sikayet_Olusturan"].HeaderText = "İstek Oluşturan";  // Sikayet_Olusturan yerine Şikayet Oluşturan
            dataGridView1.Columns["Istek_Durumu"].HeaderText = "İstek Durumu";  // Istek_Durumu yerine İstek Durumu
            dataGridView1.Columns["Baslangic_Tarihi"].HeaderText = "Başlangıç Tarihi";  // Istek_Durumu yerine İstek Durumu
            dataGridView1.Columns["Bitis_Tarihi"].HeaderText = "Bitiş Tarihi";  // Istek_Durumu yerine İstek Durumu
            dataGridView1.Columns["Istek_Fotografi"].HeaderText = "İstek Fotoğrafı";  // Istek_Durumu yerine İstek Durumu
        }

        // GÜNCEL TABLO GETİR METHODU
        private void LoadData()
        {
            var data = veritabani.Sikayet_Tablo.ToList();
            dataGridView1.DataSource = data;

        }
        
        //DATAGRİEDVİEW FRONT KODLARI
        private void ApplyDataGridViewStyle(DataGridView dataGridView)
        {
            //SÜTUN İNDEX KONUMLARI
            // Sütunların sırasını ayarlamak
            dataGridView1.Columns["Sikayet_Id"].DisplayIndex = 0;
            dataGridView1.Columns["Firma_Adi"].DisplayIndex = 1;
            dataGridView1.Columns["Firma_Personel"].DisplayIndex = 2;
            dataGridView1.Columns["Tel_No"].DisplayIndex = 3;
            dataGridView1.Columns["Sirket_Eposta"].DisplayIndex = 4;
            dataGridView1.Columns["Sikayet_Turu"].DisplayIndex = 5;
            dataGridView1.Columns["Sikayet_Aciklamasi"].DisplayIndex = 6;
            dataGridView1.Columns["Cozum_Not"].DisplayIndex = 7;
            dataGridView1.Columns["Sikayet_Olusturan"].DisplayIndex = 8;
            dataGridView1.Columns["Istek_Durumu"].DisplayIndex = 9;
            // Başlık stili
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Başlık rengini beyaz yap
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel); // Kalın (bold) font
            // Başlık yüksekliği
            dataGridView.ColumnHeadersHeight = 45; // Sütun başlık yüksekliği arttı
            // Alternatif satır renkleri
            dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            // Diğer sütunlar için renk ayarı (örnek)
            dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.DarkBlue; // 2. sütun farklı renk
            dataGridView.Columns[2].DefaultCellStyle.BackColor = Color.DarkBlue; // 2. sütun farklı renk
            // Hücre kenar stili (çizgiler)
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single; // Hücre çizgileri eklendi
            dataGridView.GridColor = Color.Black; // Hücre çizgilerinin rengi siyah
            // Sütun genişlik ayarları
            DataGridViewColumn sikayetIdColumn = dataGridView.Columns["Sikayet_Id"];
            DataGridViewColumn istekdurumColumn = dataGridView.Columns["Istek_Durumu"];
            DataGridViewColumn sikayetolusturanColumn = dataGridView.Columns["Sikayet_Olusturan"];
            DataGridViewColumn TelnoColumn = dataGridView.Columns["Tel_No"];
            DataGridViewColumn istekturColumn = dataGridView.Columns["Sikayet_Turu"];
            DataGridViewColumn sikayetaciklamaColumn = dataGridView.Columns["Sikayet_Aciklamasi"];
            DataGridViewColumn sikayetnotColumn = dataGridView.Columns["Cozum_Not"];
            DataGridViewColumn firmapersoneladColumn = dataGridView.Columns["Firma_Personel"];
            DataGridViewColumn firmadiColumn = dataGridView.Columns["Firma_Adi"];
            DataGridViewColumn baslangictarihColumn = dataGridView.Columns["Baslangic_Tarihi"];
            DataGridViewColumn bitistarihColumn = dataGridView.Columns["Bitis_Tarihi"];
            DataGridViewColumn firmaepostaColumn = dataGridView.Columns["Sirket_Eposta"];
         
            //GENİŞLİK DEĞERLERİ
            firmaepostaColumn.Width = 70;
            baslangictarihColumn.Width = 95;
            bitistarihColumn.Width = 95;
            sikayetIdColumn.Width = 25;
            istekdurumColumn.Width = 105;
            sikayetolusturanColumn.Width = 70;
            istekturColumn.Width = 65;
            TelnoColumn.Width = 80;
            sikayetaciklamaColumn.Width = 163;
            sikayetnotColumn.Width = 163;
            firmadiColumn.Width = 70;
            firmapersoneladColumn.Width = 70;

            // Satır başlıkları (RowHeaders) görünür bırakıldı
            dataGridView.RowHeadersVisible = true;
            // Satır başlıkları ile "Sikayet_Id" sütununun renk uyumu
            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.MidnightBlue; // Satır başlıklarının arka plan rengi
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.MidnightBlue; // Seçildiğinde aynı renk
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White; // Satır başlıklarının metin rengi beyaz
            // Belirli sütunların yazı tipini kalın yapmak
            dataGridView.Columns["Sikayet_Id"].DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            dataGridView.Columns["Sikayet_Turu"].DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            dataGridView.Columns["Istek_Durumu"].DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            dataGridView.Columns["Firma_Adi"].DefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold);
            //ID SÜTUNU GİZLEME
            dataGridView.Columns["Sikayet_Id"].Visible = false;
            // Seçilen hücrelerin stili
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        // DEĞER EKLEME 
        private void btn_ekle_click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txt_firmadi.Text) ||
                string.IsNullOrWhiteSpace(txt_personeladi.Text) ||
                string.IsNullOrWhiteSpace(txt_sikayetaciklamasi.Text) ||
                string.IsNullOrWhiteSpace(cmb_sikayetturu.Text) ||
                string.IsNullOrWhiteSpace(cmb_sikayetolusturan.Text))
            {
                MessageBox.Show("Firma Adı, Personel Adı, Şikayet Açıklaması, İstek Türü ve Şikayet Oluşturan alanları boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var kayitekle = new Sikayet_Tablo
            {
                Firma_Adi = txt_firmadi.Text,
                Firma_Personel = txt_personeladi.Text,
                Sikayet_Aciklamasi = txt_sikayetaciklamasi.Text,
                Tel_No = txt_telno.Text,
                Sirket_Eposta = txt_firmaeposta.Text,
                Cozum_Not = txt_cozumnot.Text,
                Sikayet_Turu = cmb_sikayetturu.Text,
                Sikayet_Olusturan = cmb_sikayetolusturan.Text,
                Istek_Fotografi = fotoğrafBytes
            };

            if (radioButtonIstekAlindi.Checked)
            {
                kayitekle.Istek_Durumu = "Istek Alındı";
                kayitekle.Baslangic_Tarihi = DateTime.Now; // Başlangıç tarihini bugünün tarihi olarak ayarla
            }
            else if (radioButtonSonuclandi.Checked)
            {
                kayitekle.Istek_Durumu = "Istek Sonuçlandı";
                kayitekle.Baslangic_Tarihi = DateTime.Now; // Başlangıç tarihini bugünün tarihi olarak ayarla
            }

            veritabani.Sikayet_Tablo.Add(kayitekle);
            veritabani.SaveChanges();

            MessageBox.Show("Veriler başarıyla eklendi.");
            LoadData();
        }

       
       

        // PARAMETRELERİ GETİR BUTONU
        private void btnGetir_Click(object sender, EventArgs e)
            
        {
            // Seçili satır olup olmadığını kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Seçili satırı al

                // Hücrelerden değerleri al ve yukarıdaki kontrol alanlarına aktar
                txt_firmadi.Text = selectedRow.Cells["Firma_Adi"].Value?.ToString();
                txt_personeladi.Text = selectedRow.Cells["Firma_Personel"].Value?.ToString();
                txt_sikayetaciklamasi.Text = selectedRow.Cells["Sikayet_Aciklamasi"].Value?.ToString();
                txt_telno.Text = selectedRow.Cells["Tel_No"].Value?.ToString();
                txt_firmaeposta.Text = selectedRow.Cells["Sirket_Eposta"].Value?.ToString();
                txt_cozumnot.Text = selectedRow.Cells["Cozum_Not"].Value?.ToString();
                cmb_sikayetturu.Text = selectedRow.Cells["Sikayet_Turu"].Value?.ToString();
                cmb_sikayetolusturan.Text = selectedRow.Cells["Sikayet_Olusturan"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir satır seçin.");
            }
        }

        // GÜNCELLEME BUTONU
        private void btnGuncel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Seçili satırı al
                int id = Convert.ToInt32(selectedRow.Cells["Sikayet_Id"].Value);  // ID'yi al

                var kayit = veritabani.Sikayet_Tablo.FirstOrDefault(s => s.Sikayet_Id == id);
                if (kayit != null)
                {
                    if (string.IsNullOrWhiteSpace(txt_firmadi.Text) ||
                string.IsNullOrWhiteSpace(txt_personeladi.Text) ||
                string.IsNullOrWhiteSpace(txt_sikayetaciklamasi.Text) ||
                string.IsNullOrWhiteSpace(cmb_sikayetturu.Text) ||
                string.IsNullOrWhiteSpace(cmb_sikayetolusturan.Text))
                    {
                        MessageBox.Show("Firma Adı, Personel Adı, Şikayet Açıklaması, İstek Türü ve Şikayet Oluşturan alanları boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    kayit.Firma_Adi = txt_firmadi.Text;
                    kayit.Firma_Personel = txt_personeladi.Text;
                    kayit.Sikayet_Aciklamasi = txt_sikayetaciklamasi.Text;
                    kayit.Tel_No = txt_telno.Text;
                    kayit.Sirket_Eposta = txt_firmaeposta.Text;
                    kayit.Cozum_Not = txt_cozumnot.Text;
                    kayit.Sikayet_Turu = cmb_sikayetturu.Text;
                    kayit.Sikayet_Olusturan = cmb_sikayetolusturan.Text;
                    kayit.Istek_Fotografi = fotoğrafBytes;
                    // RadioButton'a göre Istek_Durumu değerini ayarla
                    if (radioButtonSonuclandi.Checked)
                    {
                        kayit.Istek_Durumu = "Istek Sonuçlandı";
                        kayit.Bitis_Tarihi = DateTime.Now; // Bitiş tarihini bugünün tarihi olarak ayarla
                    }
                    else if (radioButtonSonuclandi.Checked)
                    {
                        kayit.Istek_Durumu = "Istek Sonuçlandı";
                    }
                    veritabani.SaveChanges();
                    LoadData();
                    MessageBox.Show("Veriler başarıyla güncellenmiştir.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir satır seçin.");
            }

        }

        // TEMİZLE BUTONU
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            // TextBox'ları temizle
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }

            // ComboBox'ları temizle
            foreach (Control control in groupBox1.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }

            // RichBox'ları temizle
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RichTextBox)
                {
                    ((RichTextBox)control).Clear();
                }
            }
        }  
        // SATIR SİLME BUTONU
        private void btn_satirsili_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırları silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        List<Sikayet_Tablo> silinecekKayitlar = new List<Sikayet_Tablo>();

                        // Seçili satırları geçici listeye ekleyin
                        foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                        {
                            int id = Convert.ToInt32(selectedRow.Cells["Sikayet_Id"].Value);
                            var kayit = veritabani.Sikayet_Tablo.FirstOrDefault(s => s.Sikayet_Id == id);
                            if (kayit != null)
                            {
                                silinecekKayitlar.Add(kayit);
                            }
                        }

                        // Kayıtları sil
                        foreach (var kayit in silinecekKayitlar)
                        {
                            // Silinen kaydı geçici listeye ekle
                            SilinenKayitlar.Add(kayit);
                            veritabani.Sikayet_Tablo.Remove(kayit);
                        }

                        veritabani.SaveChanges();
                        LoadData();
                        MessageBox.Show("Seçili kayıtlar başarıyla silindi.");

                        // Geri Al butonunu etkinleştir
                        btnGeriAl.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir veya daha fazla satır seçin.");
            }
        }

        // GERI AL BUTONU
        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (SilinenKayitlar.Count > 0)
            {
                try
                {
                    var kayit = SilinenKayitlar.Last(); // En son eklenen silinen kaydı al
                    SilinenKayitlar.Remove(kayit); // Listeyi güncelle

                    // Kayıt mevcutsa, yeni bir kayıt olarak ekle
                    veritabani.Sikayet_Tablo.Add(kayit);
                    veritabani.SaveChanges();
                    MessageBox.Show("Silinen kayıt başarıyla geri alındı.");

                    // Tabloyu yeniden yükle
                    LoadData();

                    // Geri alma butonunu devre dışı bırak
                    btnGeriAl.Enabled = SilinenKayitlar.Count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Geri alınacak kayıt bulunmuyor.");
            }
        }
        
        // FOTOĞRAF YÜKLEME BUTONU
        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Fotoğrafı byte dizisine dönüştürme
                        using (Image image = Image.FromFile(openFileDialog.FileName))
                        using (MemoryStream ms = new MemoryStream())
                        {
                            image.Save(ms, image.RawFormat);
                            fotoğrafBytes = ms.ToArray();
                        }

                        // TextBox'a yükleme sonucunu yazma
                        txtFotoDurum.Text = "Fotoğraf yüklendi";
                    }
                    catch (Exception ex)
                    {
                        txtFotoDurum.Text = "Yükleme başarısız";
                        MessageBox.Show($"Fotoğraf yüklenirken bir hata oluştu: {ex.Message}");
                    }
                }
            }
        }
        
        //FOTOĞRAF HÜCRESİNE DOUBLE CLİCK İLE FORM AÇMA METHODU
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Istek_Fotografi")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                byte[] fotoğrafBytes = row.Cells["Istek_Fotografi"].Value as byte[];

                using (FotoGoruntulemeForm fotoForm = new FotoGoruntulemeForm(fotoğrafBytes))
                {
                    fotoForm.ShowDialog();
                }
            }
        }

      
    }
}
