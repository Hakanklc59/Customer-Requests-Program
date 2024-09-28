
namespace Sikayet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sikayetTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriSikayetDataSet = new Sikayet.MusteriSikayetDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_telno = new System.Windows.Forms.MaskedTextBox();
            this.btnFotoSec = new System.Windows.Forms.Button();
            this.txtFotoDurum = new System.Windows.Forms.TextBox();
            this.radioButtonSonuclandi = new System.Windows.Forms.RadioButton();
            this.radioButtonIstekAlindi = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_sikayetaciklamasi = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.txt_cozumnot = new System.Windows.Forms.RichTextBox();
            this.cmb_sikayetolusturan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_sikayetturu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_firmaeposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_personeladi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_firmadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btn_satirisil = new System.Windows.Forms.Button();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.sikayet_TabloTableAdapter = new Sikayet.MusteriSikayetDataSetTableAdapters.Sikayet_TabloTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.musteriSikayetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriSikayetDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriSikayetDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriSikayetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriSikayetDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 361);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sikayetTabloBindingSource
            // 
            this.sikayetTabloBindingSource.DataMember = "Sikayet_Tablo";
            this.sikayetTabloBindingSource.DataSource = this.musteriSikayetDataSet;
            // 
            // musteriSikayetDataSet
            // 
            this.musteriSikayetDataSet.DataSetName = "MusteriSikayetDataSet";
            this.musteriSikayetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.txt_telno);
            this.groupBox1.Controls.Add(this.btnFotoSec);
            this.groupBox1.Controls.Add(this.txtFotoDurum);
            this.groupBox1.Controls.Add(this.radioButtonSonuclandi);
            this.groupBox1.Controls.Add(this.radioButtonIstekAlindi);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txt_sikayetaciklamasi);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.txt_cozumnot);
            this.groupBox1.Controls.Add(this.cmb_sikayetolusturan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_sikayetturu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_firmaeposta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_personeladi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_firmadi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(-3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_telno
            // 
            this.txt_telno.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telno.Location = new System.Drawing.Point(267, 227);
            this.txt_telno.Mask = "(999) 000-0000";
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(146, 30);
            this.txt_telno.TabIndex = 3;
            // 
            // btnFotoSec
            // 
            this.btnFotoSec.AutoSize = true;
            this.btnFotoSec.BackColor = System.Drawing.Color.SeaShell;
            this.btnFotoSec.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnFotoSec.FlatAppearance.BorderSize = 3;
            this.btnFotoSec.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnFotoSec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnFotoSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFotoSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoSec.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotoSec.ForeColor = System.Drawing.Color.Black;
            this.btnFotoSec.Location = new System.Drawing.Point(683, 276);
            this.btnFotoSec.Name = "btnFotoSec";
            this.btnFotoSec.Size = new System.Drawing.Size(97, 43);
            this.btnFotoSec.TabIndex = 9;
            this.btnFotoSec.Text = "YÜKLE";
            this.btnFotoSec.UseVisualStyleBackColor = false;
            this.btnFotoSec.Click += new System.EventHandler(this.btnFotoSec_Click);
            // 
            // txtFotoDurum
            // 
            this.txtFotoDurum.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFotoDurum.Location = new System.Drawing.Point(683, 240);
            this.txtFotoDurum.Name = "txtFotoDurum";
            this.txtFotoDurum.Size = new System.Drawing.Size(146, 29);
            this.txtFotoDurum.TabIndex = 8;
            // 
            // radioButtonSonuclandi
            // 
            this.radioButtonSonuclandi.AutoSize = true;
            this.radioButtonSonuclandi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonSonuclandi.Location = new System.Drawing.Point(683, 205);
            this.radioButtonSonuclandi.Name = "radioButtonSonuclandi";
            this.radioButtonSonuclandi.Size = new System.Drawing.Size(156, 27);
            this.radioButtonSonuclandi.TabIndex = 7;
            this.radioButtonSonuclandi.Tag = "Istek Sonuçlandı";
            this.radioButtonSonuclandi.Text = "Istek Sonuçlandı";
            this.radioButtonSonuclandi.UseVisualStyleBackColor = true;
            // 
            // radioButtonIstekAlindi
            // 
            this.radioButtonIstekAlindi.AutoSize = true;
            this.radioButtonIstekAlindi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonIstekAlindi.Location = new System.Drawing.Point(683, 168);
            this.radioButtonIstekAlindi.Name = "radioButtonIstekAlindi";
            this.radioButtonIstekAlindi.Size = new System.Drawing.Size(117, 27);
            this.radioButtonIstekAlindi.TabIndex = 6;
            this.radioButtonIstekAlindi.Tag = "Istek Alındı";
            this.radioButtonIstekAlindi.Text = "İstek Alındı";
            this.radioButtonIstekAlindi.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // txt_sikayetaciklamasi
            // 
            this.txt_sikayetaciklamasi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sikayetaciklamasi.Location = new System.Drawing.Point(899, 69);
            this.txt_sikayetaciklamasi.Name = "txt_sikayetaciklamasi";
            this.txt_sikayetaciklamasi.Size = new System.Drawing.Size(405, 100);
            this.txt_sikayetaciklamasi.TabIndex = 10;
            this.txt_sikayetaciklamasi.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(448, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "İstek Fotoğrafını Yükleyiniz:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(449, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "İstek Durumunu Seçiniz:**";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(449, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "İstek Türünü Seçiniz:**";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-268, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_temizle
            // 
            this.btn_temizle.AutoSize = true;
            this.btn_temizle.BackColor = System.Drawing.Color.SeaShell;
            this.btn_temizle.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_temizle.FlatAppearance.BorderSize = 3;
            this.btn_temizle.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btn_temizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_temizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.Location = new System.Drawing.Point(683, 70);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(119, 43);
            this.btn_temizle.TabIndex = 13;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // txt_cozumnot
            // 
            this.txt_cozumnot.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cozumnot.Location = new System.Drawing.Point(899, 202);
            this.txt_cozumnot.Name = "txt_cozumnot";
            this.txt_cozumnot.Size = new System.Drawing.Size(405, 102);
            this.txt_cozumnot.TabIndex = 11;
            this.txt_cozumnot.Text = "";
            // 
            // cmb_sikayetolusturan
            // 
            this.cmb_sikayetolusturan.BackColor = System.Drawing.Color.White;
            this.cmb_sikayetolusturan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sikayetolusturan.FormattingEnabled = true;
            this.cmb_sikayetolusturan.Items.AddRange(new object[] {
            "Berke",
            "Efe"});
            this.cmb_sikayetolusturan.Location = new System.Drawing.Point(267, 74);
            this.cmb_sikayetolusturan.Name = "cmb_sikayetolusturan";
            this.cmb_sikayetolusturan.Size = new System.Drawing.Size(147, 30);
            this.cmb_sikayetolusturan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Firma Adını Giriniz:**";
            // 
            // cmb_sikayetturu
            // 
            this.cmb_sikayetturu.BackColor = System.Drawing.Color.White;
            this.cmb_sikayetturu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_sikayetturu.FormattingEnabled = true;
            this.cmb_sikayetturu.Items.AddRange(new object[] {
            "Yazılımsal",
            "Paygo",
            "E-Arşiv",
            "E-Fatura",
            "E-İmza",
            "Atia-ERP",
            "Diğer"});
            this.cmb_sikayetturu.Location = new System.Drawing.Point(683, 126);
            this.cmb_sikayetturu.Name = "cmb_sikayetturu";
            this.cmb_sikayetturu.Size = new System.Drawing.Size(146, 30);
            this.cmb_sikayetturu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Firma Personel İsmi Giriniz:**";
            // 
            // txt_firmaeposta
            // 
            this.txt_firmaeposta.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_firmaeposta.Location = new System.Drawing.Point(267, 275);
            this.txt_firmaeposta.Name = "txt_firmaeposta";
            this.txt_firmaeposta.Size = new System.Drawing.Size(146, 29);
            this.txt_firmaeposta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(892, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Şikayet Açıklaması Giriniz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(449, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Formu Temizle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Azure;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(22, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Şikayeti Oluşturan Kişi:**";
            // 
            // txt_personeladi
            // 
            this.txt_personeladi.BackColor = System.Drawing.Color.White;
            this.txt_personeladi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_personeladi.Location = new System.Drawing.Point(267, 172);
            this.txt_personeladi.Name = "txt_personeladi";
            this.txt_personeladi.Size = new System.Drawing.Size(146, 29);
            this.txt_personeladi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefon Numarası Giriniz: ";
            // 
            // txt_firmadi
            // 
            this.txt_firmadi.BackColor = System.Drawing.Color.White;
            this.txt_firmadi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_firmadi.Location = new System.Drawing.Point(267, 122);
            this.txt_firmadi.Name = "txt_firmadi";
            this.txt_firmadi.Size = new System.Drawing.Size(146, 29);
            this.txt_firmadi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-Posta Adresini Giriniz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(895, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Çözüm Notunuzu Giriniz:";
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.AutoSize = true;
            this.btnGeriAl.BackColor = System.Drawing.Color.SeaShell;
            this.btnGeriAl.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnGeriAl.FlatAppearance.BorderSize = 3;
            this.btnGeriAl.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnGeriAl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGeriAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriAl.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriAl.ForeColor = System.Drawing.Color.Black;
            this.btnGeriAl.Location = new System.Drawing.Point(1152, 393);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(150, 50);
            this.btnGeriAl.TabIndex = 1;
            this.btnGeriAl.Text = "GERİ GETİR";
            this.btnGeriAl.UseVisualStyleBackColor = false;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btn_satirisil
            // 
            this.btn_satirisil.AutoSize = true;
            this.btn_satirisil.BackColor = System.Drawing.Color.SeaShell;
            this.btn_satirisil.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_satirisil.FlatAppearance.BorderSize = 3;
            this.btn_satirisil.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btn_satirisil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_satirisil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_satirisil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satirisil.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satirisil.ForeColor = System.Drawing.Color.Black;
            this.btn_satirisil.Location = new System.Drawing.Point(1152, 337);
            this.btn_satirisil.Name = "btn_satirisil";
            this.btn_satirisil.Size = new System.Drawing.Size(150, 50);
            this.btn_satirisil.TabIndex = 0;
            this.btn_satirisil.Text = "SATIR SİL";
            this.btn_satirisil.UseVisualStyleBackColor = false;
            this.btn_satirisil.Click += new System.EventHandler(this.btn_satirsili_Click_1);
            // 
            // btnGuncel
            // 
            this.btnGuncel.AutoSize = true;
            this.btnGuncel.BackColor = System.Drawing.Color.SeaShell;
            this.btnGuncel.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnGuncel.FlatAppearance.BorderSize = 3;
            this.btnGuncel.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuncel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuncel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncel.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncel.ForeColor = System.Drawing.Color.Black;
            this.btnGuncel.Location = new System.Drawing.Point(1148, 568);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(160, 50);
            this.btnGuncel.TabIndex = 3;
            this.btnGuncel.Text = "GÜNCELLE";
            this.btnGuncel.UseVisualStyleBackColor = false;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.AutoSize = true;
            this.btn_ekle.BackColor = System.Drawing.Color.SeaShell;
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_ekle.FlatAppearance.BorderSize = 3;
            this.btn_ekle.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_ekle.Location = new System.Drawing.Point(1148, 624);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(160, 50);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_click);
            // 
            // btnGetir
            // 
            this.btnGetir.AutoSize = true;
            this.btnGetir.BackColor = System.Drawing.Color.SeaShell;
            this.btnGetir.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnGetir.FlatAppearance.BorderSize = 3;
            this.btnGetir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnGetir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetir.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.Black;
            this.btnGetir.Location = new System.Drawing.Point(1148, 512);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(161, 50);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "SATIR GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // sikayet_TabloTableAdapter
            // 
            this.sikayet_TabloTableAdapter.ClearBeforeFill = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // musteriSikayetDataSetBindingSource
            // 
            this.musteriSikayetDataSetBindingSource.DataSource = this.musteriSikayetDataSet;
            this.musteriSikayetDataSetBindingSource.Position = 0;
            // 
            // musteriSikayetDataSetBindingSource1
            // 
            this.musteriSikayetDataSetBindingSource1.DataSource = this.musteriSikayetDataSet;
            this.musteriSikayetDataSetBindingSource1.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1330, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_satirisil);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btnGeriAl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri İstek";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriSikayetDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriSikayetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriSikayetDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_cozumnot;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.RichTextBox txt_sikayetaciklamasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_sikayetolusturan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_sikayetturu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_firmaeposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_personeladi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_firmadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnGuncel;
        private MusteriSikayetDataSet musteriSikayetDataSet;
        private System.Windows.Forms.BindingSource sikayetTabloBindingSource;
        private MusteriSikayetDataSetTableAdapters.Sikayet_TabloTableAdapter sikayet_TabloTableAdapter;
        private System.Windows.Forms.Button btn_satirisil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButtonSonuclandi;
        private System.Windows.Forms.RadioButton radioButtonIstekAlindi;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource musteriSikayetDataSetBindingSource1;
        private System.Windows.Forms.BindingSource musteriSikayetDataSetBindingSource;
        private System.Windows.Forms.MaskedTextBox txt_telno;
    }
}

