namespace HospiCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnhastakayit = new System.Windows.Forms.Button();
            this.btngörüntüle = new System.Windows.Forms.Button();
            this.btntaburcu = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnrandevukayıt = new System.Windows.Forms.Button();
            this.btnrandevuliste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhastakayit
            // 
            this.btnhastakayit.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastakayit.ForeColor = System.Drawing.Color.Maroon;
            this.btnhastakayit.Location = new System.Drawing.Point(12, 44);
            this.btnhastakayit.Name = "btnhastakayit";
            this.btnhastakayit.Size = new System.Drawing.Size(102, 28);
            this.btnhastakayit.TabIndex = 0;
            this.btnhastakayit.Text = "Hasta Kayıt";
            this.btnhastakayit.UseVisualStyleBackColor = true;
            this.btnhastakayit.Click += new System.EventHandler(this.btnhastakayit_Click);
            // 
            // btngörüntüle
            // 
            this.btngörüntüle.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngörüntüle.ForeColor = System.Drawing.Color.Maroon;
            this.btngörüntüle.Location = new System.Drawing.Point(607, 44);
            this.btngörüntüle.Name = "btngörüntüle";
            this.btngörüntüle.Size = new System.Drawing.Size(124, 28);
            this.btngörüntüle.TabIndex = 3;
            this.btngörüntüle.Text = "Bilgi Görüntüle";
            this.btngörüntüle.UseVisualStyleBackColor = true;
            this.btngörüntüle.Click += new System.EventHandler(this.btngörüntüle_Click);
            // 
            // btntaburcu
            // 
            this.btntaburcu.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntaburcu.ForeColor = System.Drawing.Color.Maroon;
            this.btntaburcu.Location = new System.Drawing.Point(120, 44);
            this.btntaburcu.Name = "btntaburcu";
            this.btntaburcu.Size = new System.Drawing.Size(93, 28);
            this.btntaburcu.TabIndex = 1;
            this.btntaburcu.Text = "Taburcu Et";
            this.btntaburcu.UseVisualStyleBackColor = true;
            this.btntaburcu.Click += new System.EventHandler(this.btntaburcu_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.ForeColor = System.Drawing.Color.Maroon;
            this.btngüncelle.Location = new System.Drawing.Point(489, 44);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(112, 28);
            this.btngüncelle.TabIndex = 2;
            this.btngüncelle.Text = "Bilgi Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.Maroon;
            this.btncikis.Location = new System.Drawing.Point(309, 89);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(94, 28);
            this.btncikis.TabIndex = 1;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnrandevukayıt
            // 
            this.btnrandevukayıt.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevukayıt.ForeColor = System.Drawing.Color.Maroon;
            this.btnrandevukayıt.Location = new System.Drawing.Point(219, 44);
            this.btnrandevukayıt.Name = "btnrandevukayıt";
            this.btnrandevukayıt.Size = new System.Drawing.Size(130, 28);
            this.btnrandevukayıt.TabIndex = 2;
            this.btnrandevukayıt.Text = "Randevu Kaydet";
            this.btnrandevukayıt.UseVisualStyleBackColor = true;
            this.btnrandevukayıt.Click += new System.EventHandler(this.btnrandevukayıt_Click);
            // 
            // btnrandevuliste
            // 
            this.btnrandevuliste.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevuliste.ForeColor = System.Drawing.Color.Maroon;
            this.btnrandevuliste.Location = new System.Drawing.Point(355, 44);
            this.btnrandevuliste.Name = "btnrandevuliste";
            this.btnrandevuliste.Size = new System.Drawing.Size(128, 28);
            this.btnrandevuliste.TabIndex = 2;
            this.btnrandevuliste.Text = "Randevu Listele";
            this.btnrandevuliste.UseVisualStyleBackColor = true;
            this.btnrandevuliste.Click += new System.EventHandler(this.btnrandevuliste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(741, 145);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btntaburcu);
            this.Controls.Add(this.btnrandevukayıt);
            this.Controls.Add(this.btnrandevuliste);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btngörüntüle);
            this.Controls.Add(this.btnhastakayit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HospiCheck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnhastakayit;
        private System.Windows.Forms.Button btngörüntüle;
        private System.Windows.Forms.Button btntaburcu;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnrandevukayıt;
        private System.Windows.Forms.Button btnrandevuliste;
    }
}

