namespace HospiCheck
{
    partial class randevuliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevuliste));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labeltarih = new System.Windows.Forms.Label();
            this.btnanamenü = new System.Windows.Forms.Button();
            this.btnrandevugetir = new System.Windows.Forms.Button();
            this.labelbaglantı = new System.Windows.Forms.Label();
            this.dateTimetarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // labeltarih
            // 
            this.labeltarih.AutoSize = true;
            this.labeltarih.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltarih.ForeColor = System.Drawing.Color.White;
            this.labeltarih.Location = new System.Drawing.Point(341, 22);
            this.labeltarih.Name = "labeltarih";
            this.labeltarih.Size = new System.Drawing.Size(55, 24);
            this.labeltarih.TabIndex = 35;
            this.labeltarih.Text = "Tarih";
            // 
            // btnanamenü
            // 
            this.btnanamenü.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanamenü.ForeColor = System.Drawing.Color.Maroon;
            this.btnanamenü.Location = new System.Drawing.Point(12, 239);
            this.btnanamenü.Name = "btnanamenü";
            this.btnanamenü.Size = new System.Drawing.Size(88, 28);
            this.btnanamenü.TabIndex = 38;
            this.btnanamenü.Text = "Ana Menü";
            this.btnanamenü.UseVisualStyleBackColor = true;
            this.btnanamenü.Click += new System.EventHandler(this.btnanamenü_Click);
            // 
            // btnrandevugetir
            // 
            this.btnrandevugetir.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevugetir.ForeColor = System.Drawing.Color.Maroon;
            this.btnrandevugetir.Location = new System.Drawing.Point(106, 239);
            this.btnrandevugetir.Name = "btnrandevugetir";
            this.btnrandevugetir.Size = new System.Drawing.Size(134, 28);
            this.btnrandevugetir.TabIndex = 38;
            this.btnrandevugetir.Text = "Randevu Sorgula";
            this.btnrandevugetir.UseVisualStyleBackColor = true;
            this.btnrandevugetir.Click += new System.EventHandler(this.btnrandevugetir_Click);
            // 
            // labelbaglantı
            // 
            this.labelbaglantı.AutoSize = true;
            this.labelbaglantı.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaglantı.ForeColor = System.Drawing.Color.White;
            this.labelbaglantı.Location = new System.Drawing.Point(8, 9);
            this.labelbaglantı.Name = "labelbaglantı";
            this.labelbaglantı.Size = new System.Drawing.Size(129, 19);
            this.labelbaglantı.TabIndex = 39;
            this.labelbaglantı.Text = "Bağlantı Kuruldu";
            // 
            // dateTimetarih
            // 
            this.dateTimetarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimetarih.Location = new System.Drawing.Point(318, 49);
            this.dateTimetarih.Name = "dateTimetarih";
            this.dateTimetarih.Size = new System.Drawing.Size(100, 20);
            this.dateTimetarih.TabIndex = 40;
            // 
            // randevuliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(736, 279);
            this.Controls.Add(this.dateTimetarih);
            this.Controls.Add(this.labelbaglantı);
            this.Controls.Add(this.btnrandevugetir);
            this.Controls.Add(this.btnanamenü);
            this.Controls.Add(this.labeltarih);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "randevuliste";
            this.Text = "HospiCheck";
            this.Load += new System.EventHandler(this.randevuliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labeltarih;
        private System.Windows.Forms.Button btnanamenü;
        private System.Windows.Forms.Button btnrandevugetir;
        private System.Windows.Forms.Label labelbaglantı;
        private System.Windows.Forms.DateTimePicker dateTimetarih;
    }
}