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

namespace Sikayet
{
    public partial class FotoGoruntulemeForm : Form
    {
        public FotoGoruntulemeForm(byte[] fotoğrafBytes)
        {
            InitializeComponent();
            if (fotoğrafBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(fotoğrafBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("Fotoğraf bulunamadı.");
            }
        }

        
    }
}
