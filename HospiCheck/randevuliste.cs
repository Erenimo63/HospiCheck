using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HospiCheck
{
    public partial class randevuliste : Form
    {
        public randevuliste()
        {
            InitializeComponent();
        }
        SQLiteConnection baglan = new SQLiteConnection();
        private void randevuliste_Load(object sender, EventArgs e)
        {
            baglan.ConnectionString = ("Data Source = DataBase/HospiCheck.db");
            btnanamenü.BackColor = Color.White;
            btnrandevugetir.BackColor = Color.White;
            try
            {
                baglan.Open();
                labelbaglantı.ForeColor = Color.White;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı Yapılamadı\n"+hata);
                labelbaglantı.Text = "Bağlantı Kurulamadı";
                labelbaglantı.ForeColor = Color.Black;
            }
        }

        private void btnanamenü_Click(object sender, EventArgs e)
        {
            Form1 anamenü = new Form1();
            this.Hide();
            anamenü.Show();
            baglan.Close();
        }

        private void btnrandevugetir_Click(object sender, EventArgs e)
        {
            SQLiteCommand bilgi = new SQLiteCommand($"select * from Randevu where Tarih='{dateTimetarih.Text}'",baglan);
            SQLiteDataAdapter da = new SQLiteDataAdapter(bilgi);
            DataSet ds = new DataSet();
            
            try
            {
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception hata)
            {
                MessageBox.Show("Getirilemedi \n"+hata);
            }
        }
    }
}
