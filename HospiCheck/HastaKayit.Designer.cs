namespace HospiCheck
{
    partial class HastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayit));
            this.labelbaglantı = new System.Windows.Forms.Label();
            this.txtkimlik = new System.Windows.Forms.TextBox();
            this.labelkimlik = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.labelisim = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.labelsoyisim = new System.Windows.Forms.Label();
            this.labelklinik = new System.Windows.Forms.Label();
            this.comboklinik = new System.Windows.Forms.ComboBox();
            this.labeldoktor = new System.Windows.Forms.Label();
            this.combodoktor = new System.Windows.Forms.ComboBox();
            this.labeltarih = new System.Windows.Forms.Label();
            this.labelsaat = new System.Windows.Forms.Label();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.btnana = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dateTimetarih = new System.Windows.Forms.DateTimePicker();
            this.btnbilgi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelbaglantı
            // 
            this.labelbaglantı.AutoSize = true;
            this.labelbaglantı.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaglantı.ForeColor = System.Drawing.Color.White;
            this.labelbaglantı.Location = new System.Drawing.Point(8, 9);
            this.labelbaglantı.Name = "labelbaglantı";
            this.labelbaglantı.Size = new System.Drawing.Size(129, 19);
            this.labelbaglantı.TabIndex = 0;
            this.labelbaglantı.Text = "Bağlantı Kuruldu";
            // 
            // txtkimlik
            // 
            this.txtkimlik.Location = new System.Drawing.Point(12, 83);
            this.txtkimlik.Name = "txtkimlik";
            this.txtkimlik.Size = new System.Drawing.Size(154, 20);
            this.txtkimlik.TabIndex = 0;
            // 
            // labelkimlik
            // 
            this.labelkimlik.AutoSize = true;
            this.labelkimlik.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkimlik.ForeColor = System.Drawing.Color.White;
            this.labelkimlik.Location = new System.Drawing.Point(12, 56);
            this.labelkimlik.Name = "labelkimlik";
            this.labelkimlik.Size = new System.Drawing.Size(154, 24);
            this.labelkimlik.TabIndex = 2;
            this.labelkimlik.Text = "Kimlik Numarası";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(172, 83);
            this.txtisim.Name = "txtisim";
            this.txtisim.ReadOnly = true;
            this.txtisim.Size = new System.Drawing.Size(126, 20);
            this.txtisim.TabIndex = 1;
            // 
            // labelisim
            // 
            this.labelisim.AutoSize = true;
            this.labelisim.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelisim.ForeColor = System.Drawing.Color.White;
            this.labelisim.Location = new System.Drawing.Point(211, 56);
            this.labelisim.Name = "labelisim";
            this.labelisim.Size = new System.Drawing.Size(48, 24);
            this.labelisim.TabIndex = 2;
            this.labelisim.Text = "İsim";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(304, 83);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.ReadOnly = true;
            this.txtsoyisim.Size = new System.Drawing.Size(126, 20);
            this.txtsoyisim.TabIndex = 2;
            // 
            // labelsoyisim
            // 
            this.labelsoyisim.AutoSize = true;
            this.labelsoyisim.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyisim.ForeColor = System.Drawing.Color.White;
            this.labelsoyisim.Location = new System.Drawing.Point(328, 56);
            this.labelsoyisim.Name = "labelsoyisim";
            this.labelsoyisim.Size = new System.Drawing.Size(78, 24);
            this.labelsoyisim.TabIndex = 2;
            this.labelsoyisim.Text = "Soyisim";
            // 
            // labelklinik
            // 
            this.labelklinik.AutoSize = true;
            this.labelklinik.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelklinik.ForeColor = System.Drawing.Color.White;
            this.labelklinik.Location = new System.Drawing.Point(32, 135);
            this.labelklinik.Name = "labelklinik";
            this.labelklinik.Size = new System.Drawing.Size(61, 24);
            this.labelklinik.TabIndex = 2;
            this.labelklinik.Text = "Klinik";
            // 
            // comboklinik
            // 
            this.comboklinik.Enabled = false;
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
            this.comboklinik.Location = new System.Drawing.Point(12, 162);
            this.comboklinik.Name = "comboklinik";
            this.comboklinik.Size = new System.Drawing.Size(100, 21);
            this.comboklinik.TabIndex = 3;
            this.comboklinik.SelectedIndexChanged += new System.EventHandler(this.comboklinik_SelectedIndexChanged);
            // 
            // labeldoktor
            // 
            this.labeldoktor.AutoSize = true;
            this.labeldoktor.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldoktor.ForeColor = System.Drawing.Color.White;
            this.labeldoktor.Location = new System.Drawing.Point(134, 134);
            this.labeldoktor.Name = "labeldoktor";
            this.labeldoktor.Size = new System.Drawing.Size(68, 24);
            this.labeldoktor.TabIndex = 2;
            this.labeldoktor.Text = "Doktor";
            // 
            // combodoktor
            // 
            this.combodoktor.Enabled = false;
            this.combodoktor.FormattingEnabled = true;
            this.combodoktor.IntegralHeight = false;
            this.combodoktor.Location = new System.Drawing.Point(118, 162);
            this.combodoktor.Name = "combodoktor";
            this.combodoktor.Size = new System.Drawing.Size(100, 21);
            this.combodoktor.TabIndex = 4;
            // 
            // labeltarih
            // 
            this.labeltarih.AutoSize = true;
            this.labeltarih.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltarih.ForeColor = System.Drawing.Color.White;
            this.labeltarih.Location = new System.Drawing.Point(247, 135);
            this.labeltarih.Name = "labeltarih";
            this.labeltarih.Size = new System.Drawing.Size(55, 24);
            this.labeltarih.TabIndex = 2;
            this.labeltarih.Text = "Tarih";
            // 
            // labelsaat
            // 
            this.labelsaat.AutoSize = true;
            this.labelsaat.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsaat.ForeColor = System.Drawing.Color.White;
            this.labelsaat.Location = new System.Drawing.Point(357, 134);
            this.labelsaat.Name = "labelsaat";
            this.labelsaat.Size = new System.Drawing.Size(47, 24);
            this.labelsaat.TabIndex = 2;
            this.labelsaat.Text = "Saat";
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(330, 162);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.ReadOnly = true;
            this.txtsaat.Size = new System.Drawing.Size(100, 20);
            this.txtsaat.TabIndex = 6;
            // 
            // btnana
            // 
            this.btnana.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnana.ForeColor = System.Drawing.Color.Maroon;
            this.btnana.Location = new System.Drawing.Point(12, 231);
            this.btnana.Name = "btnana";
            this.btnana.Size = new System.Drawing.Size(91, 28);
            this.btnana.TabIndex = 7;
            this.btnana.Text = "Ana Menü";
            this.btnana.UseVisualStyleBackColor = true;
            this.btnana.Click += new System.EventHandler(this.btnana_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.ForeColor = System.Drawing.Color.Maroon;
            this.btnkaydet.Location = new System.Drawing.Point(233, 231);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(91, 28);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dateTimetarih
            // 
            this.dateTimetarih.Enabled = false;
            this.dateTimetarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimetarih.Location = new System.Drawing.Point(224, 162);
            this.dateTimetarih.Name = "dateTimetarih";
            this.dateTimetarih.Size = new System.Drawing.Size(100, 20);
            this.dateTimetarih.TabIndex = 5;
            this.dateTimetarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnbilgi
            // 
            this.btnbilgi.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgi.ForeColor = System.Drawing.Color.Maroon;
            this.btnbilgi.Location = new System.Drawing.Point(109, 231);
            this.btnbilgi.Name = "btnbilgi";
            this.btnbilgi.Size = new System.Drawing.Size(118, 28);
            this.btnbilgi.TabIndex = 9;
            this.btnbilgi.Text = "Bilgileri Getir";
            this.btnbilgi.UseVisualStyleBackColor = true;
            this.btnbilgi.Click += new System.EventHandler(this.btnbilgi_Click);
            // 
            // HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(446, 271);
            this.Controls.Add(this.btnbilgi);
            this.Controls.Add(this.dateTimetarih);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnana);
            this.Controls.Add(this.combodoktor);
            this.Controls.Add(this.comboklinik);
            this.Controls.Add(this.txtsaat);
            this.Controls.Add(this.labelsaat);
            this.Controls.Add(this.labeltarih);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.labeldoktor);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.labelklinik);
            this.Controls.Add(this.labelsoyisim);
            this.Controls.Add(this.labelisim);
            this.Controls.Add(this.labelkimlik);
            this.Controls.Add(this.txtkimlik);
            this.Controls.Add(this.labelbaglantı);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaKayit";
            this.Text = "HospiCheck";
            this.Load += new System.EventHandler(this.HastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbaglantı;
        private System.Windows.Forms.TextBox txtkimlik;
        private System.Windows.Forms.Label labelkimlik;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label labelisim;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label labelsoyisim;
        private System.Windows.Forms.Label labelklinik;
        private System.Windows.Forms.ComboBox comboklinik;
        private System.Windows.Forms.Label labeldoktor;
        private System.Windows.Forms.ComboBox combodoktor;
        private System.Windows.Forms.Label labeltarih;
        private System.Windows.Forms.Label labelsaat;
        private System.Windows.Forms.TextBox txtsaat;
        private System.Windows.Forms.Button btnana;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DateTimePicker dateTimetarih;
        private System.Windows.Forms.Button btnbilgi;
    }
}