using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sikayet
{
    public partial class LoginForm : Form
    {
        MusteriSikayetEntities db = new MusteriSikayetEntities();

        public LoginForm()
        {
            InitializeComponent();
            {
                // Şifre kutusunun gizli karakter olarak '*' kullanmasını sağlar
                txtPassword.PasswordChar = '*';
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MusteriSikayetEntities())
            {
                string inputUserId = txtUserId.Text; // Kullanıcı girişinden ID
                string inputPassword = txtPassword.Text; // Kullanıcı girişinden şifre

                // Kullanıcı adı ve şifre boşken de giriş yapılabilmesi için kontrolü değiştiriyoruz
                var user = context.Userss
                                  .FirstOrDefault(u => (u.kullaniciadi == inputUserId || string.IsNullOrEmpty(inputUserId))
                                                    && (u.sifre == inputPassword || string.IsNullOrEmpty(inputPassword)));

                if (user != null)
                {
                    // Giriş sonrası yapılacak işlemler
                    this.Hide(); // LoginForm'u gizle
                    Form1 form1 = new Form1();
                    form1.Show(); // Ana formu göster
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
        }

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) // Eğer Enter tuşuna basılmışsa
                {
                button1_Click(this, new EventArgs()); // Butonun tıklama olayını tetikle
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Eğer Enter tuşuna basılmışsa
            {
                button1_Click(this, new EventArgs()); // Butonun tıklama olayını tetikle
            }
        }
    }
}
