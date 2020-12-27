namespace HospiCheck
{
    partial class bilgigörüntüle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilgigörüntüle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblkimlik = new System.Windows.Forms.Label();
            this.txtkimlik = new System.Windows.Forms.TextBox();
            this.labelbaglantı = new System.Windows.Forms.Label();
            this.btnanamenü = new System.Windows.Forms.Button();
            this.btnbilgigetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblkimlik
            // 
            this.lblkimlik.AutoSize = true;
            this.lblkimlik.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkimlik.ForeColor = System.Drawing.Color.White;
            this.lblkimlik.Location = new System.Drawing.Point(295, 25);
            this.lblkimlik.Name = "lblkimlik";
            this.lblkimlik.Size = new System.Drawing.Size(154, 24);
            this.lblkimlik.TabIndex = 40;
            this.lblkimlik.Text = "Kimlik Numarası";
            // 
            // txtkimlik
            // 
            this.txtkimlik.Location = new System.Drawing.Point(295, 52);
            this.txtkimlik.Name = "txtkimlik";
            this.txtkimlik.Size = new System.Drawing.Size(154, 20);
            this.txtkimlik.TabIndex = 39;
            // 
            // labelbaglantı
            // 
            this.labelbaglantı.AutoSize = true;
            this.labelbaglantı.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbaglantı.ForeColor = System.Drawing.Color.White;
            this.labelbaglantı.Location = new System.Drawing.Point(8, 9);
            this.labelbaglantı.Name = "labelbaglantı";
            this.labelbaglantı.Size = new System.Drawing.Size(129, 19);
            this.labelbaglantı.TabIndex = 62;
            this.labelbaglantı.Text = "Bağlantı Kuruldu";
            // 
            // btnanamenü
            // 
            this.btnanamenü.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanamenü.ForeColor = System.Drawing.Color.Maroon;
            this.btnanamenü.Location = new System.Drawing.Point(12, 242);
            this.btnanamenü.Name = "btnanamenü";
            this.btnanamenü.Size = new System.Drawing.Size(90, 28);
            this.btnanamenü.TabIndex = 63;
            this.btnanamenü.Text = "Ana Menü";
            this.btnanamenü.UseVisualStyleBackColor = true;
            this.btnanamenü.Click += new System.EventHandler(this.btnanamenü_Click);
            // 
            // btnbilgigetir
            // 
            this.btnbilgigetir.Font = new System.Drawing.Font("Sitka Small", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgigetir.ForeColor = System.Drawing.Color.Maroon;
            this.btnbilgigetir.Location = new System.Drawing.Point(108, 242);
            this.btnbilgigetir.Name = "btnbilgigetir";
            this.btnbilgigetir.Size = new System.Drawing.Size(112, 28);
            this.btnbilgigetir.TabIndex = 63;
            this.btnbilgigetir.Text = "Bilgileri Getir";
            this.btnbilgigetir.UseVisualStyleBackColor = true;
            this.btnbilgigetir.Click += new System.EventHandler(this.btnbilgigetir_Click);
            // 
            // bilgigörüntüle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(745, 282);
            this.Controls.Add(this.btnbilgigetir);
            this.Controls.Add(this.btnanamenü);
            this.Controls.Add(this.labelbaglantı);
            this.Controls.Add(this.lblkimlik);
            this.Controls.Add(this.txtkimlik);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bilgigörüntüle";
            this.Text = "HospiCheck";
            this.Load += new System.EventHandler(this.bilgigörüntüle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblkimlik;
        private System.Windows.Forms.TextBox txtkimlik;
        private System.Windows.Forms.Label labelbaglantı;
        private System.Windows.Forms.Button btnanamenü;
        private System.Windows.Forms.Button btnbilgigetir;
    }
}