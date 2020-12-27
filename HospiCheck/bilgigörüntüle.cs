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
    public partial class bilgigörüntüle : Form
    {
        public bilgigörüntüle()
        {
            InitializeComponent();
        }
        SQLiteConnection baglan = new SQLiteConnection();
        private void bilgigörüntüle_Load(object sender, EventArgs e)
        {
            baglan.ConnectionString=("Data Source=DataBase/HospiCheck.db");
            btnanamenü.BackColor = Color.White;
            btnbilgigetir.BackColor = Color.White;
            try
            {
                baglan.Open();
                labelbaglantı.ForeColor = Color.White;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı Yapılamadı \n Hata : "+hata);
                labelbaglantı.Text="Bağlantı Kurulamadı";
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

        private void btnbilgigetir_Click(object sender, EventArgs e)
        {
            SQLiteCommand randevu = new SQLiteCommand($"Select * from Randevu where TC_Kimlik = '{txtkimlik.Text}'",baglan);
            SQLiteDataReader randevuoku = randevu.ExecuteReader();
            SQLiteCommand hasta = new SQLiteCommand($"Select * from Hasta where TC_Kimlik = '{txtkimlik.Text}'",baglan);
            SQLiteDataReader hastaoku = hasta.ExecuteReader();
            SQLiteCommand taburcu = new SQLiteCommand($"Select * from Taburcu where TC_Kimlik = '{txtkimlik.Text}'",baglan);
            SQLiteDataReader taburcuoku = taburcu.ExecuteReader();
            
            
            if (taburcuoku.Read() && randevuoku.Read())
            {
                SQLiteCommand taburcu1 = new SQLiteCommand($"Select * from Taburcu where TC_Kimlik = '{txtkimlik.Text}'", baglan);
                SQLiteDataAdapter da = new SQLiteDataAdapter(taburcu1);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Getirilemedi \n Hata : "+hata);
                }
            }
            else if (randevuoku.Read() && hastaoku.Read())
            {
                SQLiteCommand randevu1 = new SQLiteCommand($"Select * from Randevu where TC_Kimlik = '{txtkimlik.Text}'", baglan);
                SQLiteDataAdapter da = new SQLiteDataAdapter(randevu1);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Getirilemedi \n Hata : " + hata);
                }
            }
            
        }
    }
}
