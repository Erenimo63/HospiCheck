namespace HospiCheck
{
    partial class RandevuKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuKayit));
            this.combodoktor = new System.Windows.Forms.ComboBox();
            this.comboklinik = new System.Windows.Forms.ComboBox();
            this.combokan = new System.Windows.Forms.ComboBox();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.txtboy = new System.Windows.Forms.TextBox();
            this.labelsaat = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.labelkilo = new System.Windows.Forms.Label();
            this.labeltarih = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.labelboy = new System.Windows.Forms.Label();
            this.labeldoktor = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.labelklinik = new System.Windows.Forms.Label();
            this.labelyas = new System.Windows.Forms.Label();
            this.labelsoyisim = new System.Windows.Forms.Label();
            this.labelkan = new System.Windows.Forms.Label();
            this.labelisim = new System.Windows.Forms.Label();
            this.labeltel = new System.Windows.Forms.Label();
            this.labelkimlik = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtkimlik = new System.Windows.Forms.TextBox();
            this.labelbaglantı = new System.Windows.Forms.Label();
            this.btnana = new System.Windows.Forms.Button();
            this.btnrandevukayıt = new System.Windows.Forms.Button();
            this.dateTimetarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // combodoktor
            // 
            this.combodoktor.FormattingEnabled = true;
            this.combodoktor.IntegralHeight = false;
            this.combodoktor.Location = new System.Drawing.Point(384, 161);
            this.combodoktor.Name = "combodoktor";
            this.combodoktor.Size = new System.Drawing.Size(100, 21);
            this.combodoktor.TabIndex = 33;
            // 
            // comboklinik
            // 
            this.comboklinik.FormattingEnabled = true;
            this.comboklinik.IntegralHeight = false;
            this.comboklinik.Items.AddRange(new object[] {
            "Göğüs Cerrahisi",
            "Göğüs Hastalıkları",
            "Genel Cerrahi",
            "Gastroenteroloji",
            "Üroloji",
            "Kardiyoloji",
            "Çocuk Cerrahisi"});
            this.comboklinik.Location = new System.Drawing.Point(278, 161);
            this.comboklinik.Name = "comboklinik";
            this.comboklinik.Size = new System.Drawing.Size(100, 21);
            this.comboklinik.TabIndex = 32;
            this.comboklinik.SelectedIndexChanged += new System.EventHandler(this.comboklinik_SelectedIndexChanged);
            // 
            // combokan
            // 
            this.combokan.FormattingEnabled = true;
            this.combokan.IntegralHeight = false;
            this.combokan.Items.AddRange(new object[] {
            "A RH+",
            "B RH+",
            "0 RH+",
            "AB RH+",
            "A RH-",
            "B RH-",
            "0 RH-",
            "AB RH-"});
            this.combokan.Location = new System.Drawing.Point(172, 161);
            this.combokan.Name = "combokan";
            this.combokan.Size = new System.Drawing.Size(100, 21);
            this.combokan.TabIndex = 31;
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(596, 161);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(100, 20);
            this.txtsaat.TabIndex = 35;
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(596, 83);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(100, 20);
            this.txtkilo.TabIndex = 29;
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(490, 83);
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(100, 20);
            this.txtboy.TabIndex = 28;
            // 
            // labelsaat
            // 
            this.labelsaat.AutoSize = true;
            this.labelsaat.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaat.ForeColor = System.Drawing.Color.White;
            this.labelsaat.Location = new System.Drawing.Point(623, 133);
            this.labelsaat.Name = "labelsaat";
            this.labelsaat.Size = new System.Drawing.Size(47, 24);
            this.labelsaat.TabIndex = 26;
            this.labelsaat.Text = "Saat";
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(384, 83);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(100, 20);
            this.txtyas.TabIndex = 27;
            // 
            // labelkilo
            // 
            this.labelkilo.AutoSize = true;
            this.labelkilo.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkilo.ForeColor = System.Drawing.Color.White;
            this.labelkilo.Location = new System.Drawing.Point(624, 56);
            this.labelkilo.Name = "labelkilo";
            this.labelkilo.Size = new System.Drawing.Size(44, 24);
            this.labelkilo.TabIndex = 25;
            this.labelkilo.Text = "Kilo";
            // 
            // labeltarih
            // 
            this.labeltarih.AutoSize = true;
            this.labeltarih.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltarih.ForeColor = System.Drawing.Color.White;
            this.labeltarih.Location = new System.Drawing.Point(513, 134);
            this.labeltarih.Name = "labeltarih";
            this.labeltarih.Size = new System.Drawing.Size(55, 24);
            this.labeltarih.TabIndex = 24;
            this.labeltarih.Text = "Tarih";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(278, 83);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtsoyisim.TabIndex = 23;
            // 
            // labelboy
            // 
            this.labelboy.AutoSize = true;
            this.labelboy.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelboy.ForeColor = System.Drawing.Color.White;
            this.labelboy.Location = new System.Drawing.Point(519, 56);
            this.labelboy.Name = "labelboy";
            this.labelboy.Size = new System.Drawing.Size(43, 24);
            this.labelboy.TabIndex = 22;
            this.labelboy.Text = "Boy";
            // 
            // labeldoktor
            // 
            this.labeldoktor.AutoSize = true;
            this.labeldoktor.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldoktor.ForeColor = System.Drawing.Color.White;
            this.labeldoktor.Location = new System.Drawing.Point(400, 133);
            this.labeldoktor.Name = "labeldoktor";
            this.labeldoktor.Size = new System.Drawing.Size(68, 24);
            this.labeldoktor.TabIndex = 21;
            this.labeldoktor.Text = "Doktor";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(172, 83);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 20);
            this.txtisim.TabIndex = 13;
            // 
            // labelklinik
            // 
            this.labelklinik.AutoSize = true;
            this.labelklinik.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelklinik.ForeColor = System.Drawing.Color.White;
            this.labelklinik.Location = new System.Drawing.Point(298, 134);
            this.labelklinik.Name = "labelklinik";
            this.labelklinik.Size = new System.Drawing.Size(61, 24);
            this.labelklinik.TabIndex = 20;
            this.labelklinik.Text = "Klinik";
            // 
            // labelyas
            // 
            this.labelyas.AutoSize = true;
            this.labelyas.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyas.ForeColor = System.Drawing.Color.White;
            this.labelyas.Location = new System.Drawing.Point(415, 56);
            this.labelyas.Name = "labelyas";
            this.labelyas.Size = new System.Drawing.Size(39, 24);
            this.labelyas.TabIndex = 19;
            this.labelyas.Text = "Yaş";
            // 
            // labelsoyisim
            // 
            this.labelsoyisim.AutoSize = true;
            this.labelsoyisim.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyisim.ForeColor = System.Drawing.Color.White;
            this.labelsoyisim.Location = new System.Drawing.Point(289, 56);
            this.labelsoyisim.Name = "labelsoyisim";
            this.labelsoyisim.Size = new System.Drawing.Size(78, 24);
            this.labelsoyisim.TabIndex = 18;
            this.labelsoyisim.Text = "Soyisim";
            // 
            // labelkan
            // 
            this.labelkan.AutoSize = true;
            this.labelkan.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkan.ForeColor = System.Drawing.Color.White;
            this.labelkan.Location = new System.Drawing.Point(172, 134);
            this.labelkan.Name = "labelkan";
            this.labelkan.Size = new System.Drawing.Size(100, 24);
            this.labelkan.TabIndex = 17;
            this.labelkan.Text = "Kan Grubu";
            // 
            // labelisim
            // 
            this.labelisim.AutoSize = true;
            this.labelisim.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelisim.ForeColor = System.Drawing.Color.White;
            this.labelisim.Location = new System.Drawing.Point(198, 56);
            this.labelisim.Name = "labelisim";
            this.labelisim.Size = new System.Drawing.Size(48, 24);
            this.labelisim.TabIndex = 16;
            this.labelisim.Text = "İsim";
            // 
            // labeltel
            // 
            this.labeltel.AutoSize = true;
            this.labeltel.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltel.ForeColor = System.Drawing.Color.White;
            this.labeltel.Location = new System.Drawing.Point(9, 134);
            this.labeltel.Name = "labeltel";
            this.labeltel.Size = new System.Drawing.Size(160, 24);
            this.labeltel.TabIndex = 15;
            this.labeltel.Text = "Telefon Numarası";
            // 
            // labelkimlik
            // 
            this.labelkimlik.AutoSize = true;
            this.labelkimlik.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkimlik.ForeColor = System.Drawing.Color.White;
            this.labelkimlik.Location = new System.Drawing.Point(12, 56);
            this.labelkimlik.Name = "labelkimlik";
            this.labelkimlik.Size = new System.Drawing.Size(154, 24);
            this.labelkimlik.TabIndex = 14;
            this.labelkimlik.Text = "Kimlik Numarası";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(12, 161);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(154, 20);
            this.txttel.TabIndex = 30;
            // 
            // txtkimlik
            // 
            this.txtkimlik.Location = new System.Drawing.Point(12, 83);
            this.txtkimlik.Name = "txtkimlik";
            this.txtkimlik.Size = new System.Drawing.Size(154, 20);
            this.txtkimlik.TabIndex = 12;
            // 
            // labelbaglantı
            // 
            this.labelbaglantı.AutoSize = true;
            this.labelbaglantı.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaglantı.ForeColor = System.Drawing.Color.White;
            this.labelbaglantı.Location = new System.Drawing.Point(8, 9);
            this.labelbaglantı.Name = "labelbaglantı";
            this.labelbaglantı.Size = new System.Drawing.Size(129, 19);
            this.labelbaglantı.TabIndex = 36;
            this.labelbaglantı.Text = "Bağlantı Kuruldu";
            // 
            // btnana
            // 
            this.btnana.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnana.ForeColor = System.Drawing.Color.Maroon;
            this.btnana.Location = new System.Drawing.Point(12, 207);
            this.btnana.Name = "btnana";
            this.btnana.Size = new System.Drawing.Size(87, 28);
            this.btnana.TabIndex = 37;
            this.btnana.Text = "Ana Menü";
            this.btnana.UseVisualStyleBackColor = true;
            this.btnana.Click += new System.EventHandler(this.btnana_Click);
            // 
            // btnrandevukayıt
            // 
            this.btnrandevukayıt.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevukayıt.ForeColor = System.Drawing.Color.Maroon;
            this.btnrandevukayıt.Location = new System.Drawing.Point(105, 207);
            this.btnrandevukayıt.Name = "btnrandevukayıt";
            this.btnrandevukayıt.Size = new System.Drawing.Size(131, 28);
            this.btnrandevukayıt.TabIndex = 37;
            this.btnrandevukayıt.Text = "Randevu Kaydet";
            this.btnrandevukayıt.UseVisualStyleBackColor = true;
            this.btnrandevukayıt.Click += new System.EventHandler(this.btnrandevukayıt_Click);
            // 
            // dateTimetarih
            // 
            this.dateTimetarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimetarih.Location = new System.Drawing.Point(490, 162);
            this.dateTimetarih.Name = "dateTimetarih";
            this.dateTimetarih.Size = new System.Drawing.Size(100, 20);
            this.dateTimetarih.TabIndex = 38;
            // 
            // RandevuKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(710, 247);
            this.Controls.Add(this.dateTimetarih);
            this.Controls.Add(this.btnrandevukayıt);
            this.Controls.Add(this.btnana);
            this.Controls.Add(this.labelbaglantı);
            this.Controls.Add(this.combodoktor);
            this.Controls.Add(this.comboklinik);
            this.Controls.Add(this.combokan);
            this.Controls.Add(this.txtsaat);
            this.Controls.Add(this.txtkilo);
            this.Controls.Add(this.txtboy);
            this.Controls.Add(this.labelsaat);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.labelkilo);
            this.Controls.Add(this.labeltarih);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.labelboy);
            this.Controls.Add(this.labeldoktor);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.labelklinik);
            this.Controls.Add(this.labelyas);
            this.Controls.Add(this.labelsoyisim);
            this.Controls.Add(this.labelkan);
            this.Controls.Add(this.labelisim);
            this.Controls.Add(this.labeltel);
            this.Controls.Add(this.labelkimlik);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtkimlik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandevuKayit";
            this.Text = "HospiCheck";
            this.Load += new System.EventHandler(this.RandevuKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combodoktor;
        private System.Windows.Forms.ComboBox comboklinik;
        private System.Windows.Forms.ComboBox combokan;
        private System.Windows.Forms.TextBox txtsaat;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.TextBox txtboy;
        private System.Windows.Forms.Label labelsaat;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.Label labelkilo;
        private System.Windows.Forms.Label labeltarih;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label labelboy;
        private System.Windows.Forms.Label labeldoktor;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label labelklinik;
        private System.Windows.Forms.Label labelyas;
        private System.Windows.Forms.Label labelsoyisim;
        private System.Windows.Forms.Label labelkan;
        private System.Windows.Forms.Label labelisim;
        private System.Windows.Forms.Label labeltel;
        private System.Windows.Forms.Label labelkimlik;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtkimlik;
        private System.Windows.Forms.Label labelbaglantı;
        private System.Windows.Forms.Button btnana;
        private System.Windows.Forms.Button btnrandevukayıt;
        private System.Windows.Forms.DateTimePicker dateTimetarih;
    }
}