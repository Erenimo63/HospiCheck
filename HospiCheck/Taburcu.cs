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
    public partial class Taburcu : Form
    {
        public Taburcu()
        {
            InitializeComponent();
        }
        SQLiteConnection baglan = new SQLiteConnection();
        private void Taburcu_Load(object sender, EventArgs e)
        {
            baglan.ConnectionString = ("Data Source=DataBase/HospiCheck.db");
            btnana.BackColor = Color.White;
            btnbilgi.BackColor = Color.White;
            btntaburcu.BackColor = Color.White;
            try
            {
                baglan.Open();
                labelbaglantı.ForeColor = Color.White;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı Yapılamadı \n hata : "+hata);
                labelbaglantı.ForeColor = Color.Black;
                labelbaglantı.Text = "Bağlantı Kurulamadı";
            }
        }

        private void btnana_Click(object sender, EventArgs e)
        {
            Form1 anamenü = new Form1();
            this.Close();
            anamenü.Show();
            baglan.Close();
        }

        private void btnbilgi_Click(object sender, EventArgs e)
        {
            SQLiteCommand bilgi = new SQLiteCommand("select İsim,Soyisim,Klinik,Doktor from Randevu where TC_Kimlik=@kimlik",baglan);
            SQLiteParameter prm = new SQLiteParameter("@kimlik",txtkimlik.Text);
            bilgi.Parameters.Add(prm);
            SQLiteDataReader oku = bilgi.ExecuteReader();
            try
            {
                oku.Read();
                txtisim.Text = oku["İsim"].ToString();
                txtsoyisim.Text = oku["Soyisim"].ToString();
                txtklinik.Text = oku["Klinik"].ToString();
                txtdoktor.Text = oku["Doktor"].ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : "+hata);
            }
            
        }

        private void btntaburcu_Click(object sender, EventArgs e)
        {
            string durum = "Taburcu";
            SQLiteCommand sil = new SQLiteCommand("Delete from hasta where TC_Kimlik=@kimlik",baglan);
            SQLiteParameter prm = new SQLiteParameter("@kimlik",txtkimlik.Text);
            sil.Parameters.Add(prm);
            SQLiteCommand kayit = new SQLiteCommand($"insert into Taburcu(TC_Kimlik,İsim,Soyisim,Yas,Ücret,Durum) values ('{txtkimlik.Text}','{txtisim.Text}','{txtsoyisim.Text}','{txtklinik.Text}','{txtücret.Text}','{durum}')",baglan);
            try
            {
                sil.ExecuteNonQuery();
                kayit.ExecuteNonQuery();
                MessageBox.Show("Taburcu Edildi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Taburcu Edilemedi \n hata : "+hata);
            }
        }
    }
}
