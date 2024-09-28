using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sikayet
{
    public partial class updateForm : Form
    {
        public string UpdatedValue { get; private set; }  // TextBox'a girilen değeri döndürmek için
        public bool IsUpdated { get; private set; } = false; // Güncelleme yapılmış mı?
        private string originalValue;

        public updateForm(string currentValue)
        {
            InitializeComponent();
            originalValue = currentValue;
            txt_yenideger.Text = currentValue;  // Hücredeki mevcut değeri TextBox'a koymak

            // KeyDown olayını bağlayın
            txt_yenideger.KeyDown += txt_yenideger_KeyDown;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SaveValue();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Formu kapat
            this.Close(); // Formu kapat
        }

        private void updateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsUpdated && this.DialogResult != DialogResult.OK)
            {
                // Formun kapatılmasını engelleyebilirsiniz ya da kullanıcıya uyarı verebilirsiniz
            }
        }

        private void txt_yenideger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuşunun formda diğer işlevleri tetiklemesini engelle
                SaveValue(); // Kaydet butonuna tıklamış gibi davran
            }
        }

        private void SaveValue()
        {
            string newValue = txt_yenideger.Text;  // Girilen değeri al
            IsUpdated = true;
            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Değer boş bırakılamaz. Lütfen bir değer girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdatedValue = newValue;
            this.DialogResult = DialogResult.OK; // Formu kapat
            this.Close();
        }
    }

}

