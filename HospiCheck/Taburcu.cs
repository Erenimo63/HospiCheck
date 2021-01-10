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
            SQLiteCommand bilgi = new SQLiteCommand("select İsim,Soyisim,Klinik,Doktor from Hasta where TC_Kimlik=@kimlik",baglan);
            SQLiteParameter prm = new SQLiteParameter("@kimlik",txtkimlik.Text);
            bilgi.Parameters.Add(prm);
            SQLiteDataReader oku = bilgi.ExecuteReader();
            try
            {
                oku.Read();
                txtisim.Text = oku["İsim"].ToString();
                txtsoyisim.Text = oku["Soyisim"].ToString();
                comboklinik.Text = oku["Klinik"].ToString();
                combodoktor.Text = oku["Doktor"].ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : "+hata);
            }
            
        }

        private void btntaburcu_Click(object sender, EventArgs e)
        {
            string durum = "Taburcu";
            string durum2 = "Taburcu Edildi"; 
            SQLiteCommand sil = new SQLiteCommand("Delete from hasta where TC_Kimlik=@kimlik",baglan);
            SQLiteParameter prm = new SQLiteParameter("@kimlik",txtkimlik.Text);
            sil.Parameters.Add(prm);
            SQLiteCommand kayit = new SQLiteCommand($"insert into Taburcu(TC_Kimlik,İsim,Soyisim,Klinik,Doktor,Ücret,Durum) values ('{txtkimlik.Text}','{txtisim.Text}','{txtsoyisim.Text}','{comboklinik.Text}','{combodoktor.Text}','{txtücret.Text}','{durum}')",baglan);
            try
            {
                SQLiteCommand durum1 = new SQLiteCommand("update Randevu set Durum = @durum where TC_Kimlik= @kimlik", baglan);
                SQLiteParameter prm1 = new SQLiteParameter("@durum", durum2);
                SQLiteParameter prm2 = new SQLiteParameter("@kimlik", txtkimlik.Text);
                durum1.Parameters.Add(prm1);
                durum1.Parameters.Add(prm2);
                durum1.ExecuteNonQuery();
                sil.ExecuteNonQuery();
                kayit.ExecuteNonQuery();
                MessageBox.Show("Taburcu Edildi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Taburcu Edilemedi \n hata : "+hata);
            }
        }

        private void comboklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboklinik.Text == "Göğüs Hastalıkları")
            {
                combodoktor.Items.Add("Hasan BAŞARAN");
                combodoktor.Items.Add("Eren ATAY");
                combodoktor.Items.Add("Fatma VURAL");
                combodoktor.Items.Add("Sevinç AK");

            }
            else if (comboklinik.Text != "Göğüs Hastalıkları")
            {
                combodoktor.Items.Remove("Hasan BAŞARAN");
                combodoktor.Items.Remove("Eren ATAY");
                combodoktor.Items.Remove("Fatma VURAL");
                combodoktor.Items.Remove("Sevinç AK");
            }
            if (comboklinik.Text == "Göğüs Cerrahisi")
            {
                combodoktor.Items.Add("Cihan AKPINAR");
                combodoktor.Items.Add("Semina AKTUNA");
                combodoktor.Items.Add("Elif ALTIN");
                combodoktor.Items.Add("Murat AYDOĞDU");
            }
            else if (comboklinik.Text != "Göğüs Cerrahisi")
            {
                combodoktor.Items.Remove("Cihan AKPINAR");
                combodoktor.Items.Remove("Semina AKTUNA");
                combodoktor.Items.Remove("Elif ALTIN");
                combodoktor.Items.Remove("Murat AYDOĞDU");
            }
            if (comboklinik.Text == "Genel Cerrahi")
            {
                combodoktor.Items.Add("Melike BÜLBÜL");
                combodoktor.Items.Add("Özen CEYLAN");
                combodoktor.Items.Add("Sema ÇAPA");
                combodoktor.Items.Add("Ergün ESEN");
            }
            else if (comboklinik.Text != "Genel Cerrahi")
            {
                combodoktor.Items.Remove("Melike BÜLBÜL");
                combodoktor.Items.Remove("Özen CEYLAN");
                combodoktor.Items.Remove("Sema ÇAPA");
                combodoktor.Items.Remove("Ergün ESEN");
            }
            if (comboklinik.Text == "Gastroenteroloji")
            {
                combodoktor.Items.Add("Mustafa ASLAN");
                combodoktor.Items.Add("Ayşegül DURAN");
                combodoktor.Items.Add("Adem GÜLER");
                combodoktor.Items.Add("Emrah ÇİFT");
            }
            else if (comboklinik.Text != "Gastroenteroloji")
            {
                combodoktor.Items.Remove("Mustafa ASLAN");
                combodoktor.Items.Remove("Ayşegül DURAN");
                combodoktor.Items.Remove("Adem GÜLER");
                combodoktor.Items.Remove("Emrah ÇİFT");
            }
            if (comboklinik.Text == "Üroloji")
            {
                combodoktor.Items.Add("Celal AYRIM");
                combodoktor.Items.Add("Mutlu ABACIOĞLU");
                combodoktor.Items.Add("Rüya SEZİKLİ");
                combodoktor.Items.Add("Ahmet ÖZDEŞ");
            }
            else if (comboklinik.Text != "Üroloji")
            {
                combodoktor.Items.Remove("Celal AYRIM");
                combodoktor.Items.Remove("Mutlu ABACIOĞLU");
                combodoktor.Items.Remove("Rüya SEZİKLİ");
                combodoktor.Items.Remove("Ahmet ÖZDEŞ");
            }
            if (comboklinik.Text == "Kardiyoloji")
            {
                combodoktor.Items.Add("Kazım BEKİR");
                combodoktor.Items.Add("Sena ÇİLESİZ");
                combodoktor.Items.Add("Aynur CEYLAN");
                combodoktor.Items.Add("Ganim URUÇ");
            }
            else if (comboklinik.Text != "Kardiyoloji")
            {
                combodoktor.Items.Remove("Kazım BEKİR");
                combodoktor.Items.Remove("Sena ÇİLESİZ");
                combodoktor.Items.Remove("Aynur CEYLAN");
                combodoktor.Items.Remove("Ganim URUÇ");
            }
            if (comboklinik.Text == "Çocuk Cerrahisi")
            {
                combodoktor.Items.Add("Murat YILDIRIM");
                combodoktor.Items.Add("Merve Nur AKYÜZ");
                combodoktor.Items.Add("Hanife YEĞEN");
                combodoktor.Items.Add("Gürol YARDIMCI");
            }
            else if (comboklinik.Text != "Çocuk Cerrahisi")
            {
                combodoktor.Items.Remove("Murat YILDIRIM");
                combodoktor.Items.Remove("Merve Nur AKYÜZ");
                combodoktor.Items.Remove("Hanife YEĞEN");
                combodoktor.Items.Remove("Gürol YARDIMCI");
            }
        }
    }
}
