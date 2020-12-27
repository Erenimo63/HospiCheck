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
    public partial class bilgigüncelle : Form
    {
        public bilgigüncelle()
        {
            InitializeComponent();
        }
        SQLiteConnection baglan = new SQLiteConnection();
        private void bilgigüncelle_Load(object sender, EventArgs e)
        {
            baglan.ConnectionString=("Data Source = DataBase/HospiCheck.db");
            btnanamenü.BackColor = Color.White;
            btnbilgigetir.BackColor = Color.White;
            btngüncelle.BackColor = Color.White;
            try
            {
                baglan.Open();
                labelbaglantı.ForeColor = Color.White;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı Yapılamadı \n Hata : "+hata);
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

        private void btnbilgigetir_Click(object sender, EventArgs e)
        {
            SQLiteCommand bilgi = new SQLiteCommand($"select * from Randevu where TC_Kimlik = '{txtkimlik.Text}'",baglan);
            SQLiteDataAdapter da = new SQLiteDataAdapter(bilgi);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            txtkimlik1.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            txtisim.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            txtsoyisim.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            txtyas.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            txtboy.Text = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            txtkilo.Text = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            txttel.Text = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            combokan.Text = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();
            comboklinik.Text = dataGridView1.Rows[seçilialan].Cells[8].Value.ToString();
            combodoktor.Text = dataGridView1.Rows[seçilialan].Cells[9].Value.ToString();
            dateTimetarih.Text = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();
            txtsaat.Text = dataGridView1.Rows[seçilialan].Cells[11].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SQLiteCommand güncelle = new SQLiteCommand($"update Randevu Set İsim='{txtisim.Text}',Soyisim='{txtsoyisim.Text}',Yas='{txtyas.Text}',Boy='{txtboy.Text}',Kilo='{txtkilo.Text}',Telefon_Numarası='{txttel.Text}',Kan_Grubu='{combokan.Text}',Klinik='{comboklinik.Text}',Doktor='{combodoktor.Text}',Tarih='{dateTimetarih.Text}',Saat='{txtsaat.Text}' where TC_Kimlik = '{txtkimlik.Text}'",baglan);
            try
            {
                güncelle.ExecuteNonQuery();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncellenemedi \n Hata : "+hata);
            }
        }
    }
}
