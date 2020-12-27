namespace HospiCheck
{
    partial class bilgigüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilgigüncelle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.txtkimlik1 = new System.Windows.Forms.TextBox();
            this.txtkimlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnanamenü = new System.Windows.Forms.Button();
            this.labelbaglantı = new System.Windows.Forms.Label();
            this.btnbilgigetir = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.dateTimetarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 62);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // combodoktor
            // 
            this.combodoktor.FormattingEnabled = true;
            this.combodoktor.IntegralHeight = false;
            this.combodoktor.Location = new System.Drawing.Point(387, 251);
            this.combodoktor.Name = "combodoktor";
            this.combodoktor.Size = new System.Drawing.Size(100, 21);
            this.combodoktor.TabIndex = 57;
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
            this.comboklinik.Location = new System.Drawing.Point(281, 251);
            this.comboklinik.Name = "comboklinik";
            this.comboklinik.Size = new System.Drawing.Size(100, 21);
            this.comboklinik.TabIndex = 56;
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
            this.combokan.Location = new System.Drawing.Point(175, 251);
            this.combokan.Name = "combokan";
            this.combokan.Size = new System.Drawing.Size(100, 21);
            this.combokan.TabIndex = 55;
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(599, 251);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(100, 20);
            this.txtsaat.TabIndex = 59;
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(599, 173);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(100, 20);
            this.txtkilo.TabIndex = 53;
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(493, 173);
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(100, 20);
            this.txtboy.TabIndex = 52;
            // 
            // labelsaat
            // 
            this.labelsaat.AutoSize = true;
            this.labelsaat.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaat.ForeColor = System.Drawing.Color.White;
            this.labelsaat.Location = new System.Drawing.Point(626, 223);
            this.labelsaat.Name = "labelsaat";
            this.labelsaat.Size = new System.Drawing.Size(47, 24);
            this.labelsaat.TabIndex = 50;
            this.labelsaat.Text = "Saat";
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(387, 173);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(100, 20);
            this.txtyas.TabIndex = 51;
            // 
            // labelkilo
            // 
            this.labelkilo.AutoSize = true;
            this.labelkilo.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkilo.ForeColor = System.Drawing.Color.White;
            this.labelkilo.Location = new System.Drawing.Point(627, 146);
            this.labelkilo.Name = "labelkilo";
            this.labelkilo.Size = new System.Drawing.Size(44, 24);
            this.labelkilo.TabIndex = 49;
            this.labelkilo.Text = "Kilo";
            // 
            // labeltarih
            // 
            this.labeltarih.AutoSize = true;
            this.labeltarih.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltarih.ForeColor = System.Drawing.Color.White;
            this.labeltarih.Location = new System.Drawing.Point(516, 224);
            this.labeltarih.Name = "labeltarih";
            this.labeltarih.Size = new System.Drawing.Size(55, 24);
            this.labeltarih.TabIndex = 48;
            this.labeltarih.Text = "Tarih";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(281, 173);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtsoyisim.TabIndex = 47;
            // 
            // labelboy
            // 
            this.labelboy.AutoSize = true;
            this.labelboy.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelboy.ForeColor = System.Drawing.Color.White;
            this.labelboy.Location = new System.Drawing.Point(522, 146);
            this.labelboy.Name = "labelboy";
            this.labelboy.Size = new System.Drawing.Size(43, 24);
            this.labelboy.TabIndex = 46;
            this.labelboy.Text = "Boy";
            // 
            // labeldoktor
            // 
            this.labeldoktor.AutoSize = true;
            this.labeldoktor.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldoktor.ForeColor = System.Drawing.Color.White;
            this.labeldoktor.Location = new System.Drawing.Point(403, 223);
            this.labeldoktor.Name = "labeldoktor";
            this.labeldoktor.Size = new System.Drawing.Size(68, 24);
            this.labeldoktor.TabIndex = 45;
            this.labeldoktor.Text = "Doktor";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(175, 173);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 20);
            this.txtisim.TabIndex = 37;
            // 
            // labelklinik
            // 
            this.labelklinik.AutoSize = true;
            this.labelklinik.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelklinik.ForeColor = System.Drawing.Color.White;
            this.labelklinik.Location = new System.Drawing.Point(301, 224);
            this.labelklinik.Name = "labelklinik";
            this.labelklinik.Size = new System.Drawing.Size(61, 24);
            this.labelklinik.TabIndex = 44;
            this.labelklinik.Text = "Klinik";
            // 
            // labelyas
            // 
            this.labelyas.AutoSize = true;
            this.labelyas.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyas.ForeColor = System.Drawing.Color.White;
            this.labelyas.Location = new System.Drawing.Point(418, 146);
            this.labelyas.Name = "labelyas";
            this.labelyas.Size = new System.Drawing.Size(39, 24);
            this.labelyas.TabIndex = 43;
            this.labelyas.Text = "Yaş";
            // 
            // labelsoyisim
            // 
            this.labelsoyisim.AutoSize = true;
            this.labelsoyisim.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyisim.ForeColor = System.Drawing.Color.White;
            this.labelsoyisim.Location = new System.Drawing.Point(292, 146);
            this.labelsoyisim.Name = "labelsoyisim";
            this.labelsoyisim.Size = new System.Drawing.Size(78, 24);
            this.labelsoyisim.TabIndex = 42;
            this.labelsoyisim.Text = "Soyisim";
            // 
            // labelkan
            // 
            this.labelkan.AutoSize = true;
            this.labelkan.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkan.ForeColor = System.Drawing.Color.White;
            this.labelkan.Location = new System.Drawing.Point(175, 224);
            this.labelkan.Name = "labelkan";
            this.labelkan.Size = new System.Drawing.Size(100, 24);
            this.labelkan.TabIndex = 41;
            this.labelkan.Text = "Kan Grubu";
            // 
            // labelisim
            // 
            this.labelisim.AutoSize = true;
            this.labelisim.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelisim.ForeColor = System.Drawing.Color.White;
            this.labelisim.Location = new System.Drawing.Point(201, 146);
            this.labelisim.Name = "labelisim";
            this.labelisim.Size = new System.Drawing.Size(48, 24);
            this.labelisim.TabIndex = 40;
            this.labelisim.Text = "İsim";
            // 
            // labeltel
            // 
            this.labeltel.AutoSize = true;
            this.labeltel.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltel.ForeColor = System.Drawing.Color.White;
            this.labeltel.Location = new System.Drawing.Point(12, 224);
            this.labeltel.Name = "labeltel";
            this.labeltel.Size = new System.Drawing.Size(160, 24);
            this.labeltel.TabIndex = 39;
            this.labeltel.Text = "Telefon Numarası";
            // 
            // labelkimlik
            // 
            this.labelkimlik.AutoSize = true;
            this.labelkimlik.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkimlik.ForeColor = System.Drawing.Color.White;
            this.labelkimlik.Location = new System.Drawing.Point(15, 146);
            this.labelkimlik.Name = "labelkimlik";
            this.labelkimlik.Size = new System.Drawing.Size(154, 24);
            this.labelkimlik.TabIndex = 38;
            this.labelkimlik.Text = "Kimlik Numarası";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(15, 251);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(154, 20);
            this.txttel.TabIndex = 54;
            // 
            // txtkimlik1
            // 
            this.txtkimlik1.Location = new System.Drawing.Point(15, 173);
            this.txtkimlik1.Name = "txtkimlik1";
            this.txtkimlik1.ReadOnly = true;
            this.txtkimlik1.Size = new System.Drawing.Size(154, 20);
            this.txtkimlik1.TabIndex = 36;
            // 
            // txtkimlik
            // 
            this.txtkimlik.Location = new System.Drawing.Point(278, 40);
            this.txtkimlik.Name = "txtkimlik";
            this.txtkimlik.Size = new System.Drawing.Size(154, 20);
            this.txtkimlik.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kimlik Numarası";
            // 
            // btnanamenü
            // 
            this.btnanamenü.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanamenü.ForeColor = System.Drawing.Color.Maroon;
            this.btnanamenü.Location = new System.Drawing.Point(12, 288);
            this.btnanamenü.Name = "btnanamenü";
            this.btnanamenü.Size = new System.Drawing.Size(87, 28);
            this.btnanamenü.TabIndex = 60;
            this.btnanamenü.Text = "Ana Menü";
            this.btnanamenü.UseVisualStyleBackColor = true;
            this.btnanamenü.Click += new System.EventHandler(this.btnanamenü_Click);
            // 
            // labelbaglantı
            // 
            this.labelbaglantı.AutoSize = true;
            this.labelbaglantı.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaglantı.ForeColor = System.Drawing.Color.White;
            this.labelbaglantı.Location = new System.Drawing.Point(8, 9);
            this.labelbaglantı.Name = "labelbaglantı";
            this.labelbaglantı.Size = new System.Drawing.Size(129, 19);
            this.labelbaglantı.TabIndex = 61;
            this.labelbaglantı.Text = "Bağlantı Kuruldu";
            // 
            // btnbilgigetir
            // 
            this.btnbilgigetir.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgigetir.ForeColor = System.Drawing.Color.Maroon;
            this.btnbilgigetir.Location = new System.Drawing.Point(105, 288);
            this.btnbilgigetir.Name = "btnbilgigetir";
            this.btnbilgigetir.Size = new System.Drawing.Size(112, 28);
            this.btnbilgigetir.TabIndex = 60;
            this.btnbilgigetir.Text = "Bilgileri Getir";
            this.btnbilgigetir.UseVisualStyleBackColor = true;
            this.btnbilgigetir.Click += new System.EventHandler(this.btnbilgigetir_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.Color.Maroon;
            this.btngüncelle.Location = new System.Drawing.Point(223, 288);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(78, 28);
            this.btngüncelle.TabIndex = 60;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // dateTimetarih
            // 
            this.dateTimetarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimetarih.Location = new System.Drawing.Point(493, 251);
            this.dateTimetarih.Name = "dateTimetarih";
            this.dateTimetarih.Size = new System.Drawing.Size(100, 20);
            this.dateTimetarih.TabIndex = 62;
            // 
            // bilgigüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(713, 328);
            this.Controls.Add(this.dateTimetarih);
            this.Controls.Add(this.labelbaglantı);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnbilgigetir);
            this.Controls.Add(this.btnanamenü);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelkimlik);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtkimlik);
            this.Controls.Add(this.txtkimlik1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bilgigüncelle";
            this.Text = "HospiCheck";
            this.Load += new System.EventHandler(this.bilgigüncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox txtkimlik1;
        private System.Windows.Forms.TextBox txtkimlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnanamenü;
        private System.Windows.Forms.Label labelbaglantı;
        private System.Windows.Forms.Button btnbilgigetir;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.DateTimePicker dateTimetarih;
    }
}