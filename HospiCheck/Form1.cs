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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnhastakayit.BackColor = Color.White;
            btngörüntüle.BackColor = Color.White;
            btngüncelle.BackColor = Color.White;
            btntaburcu.BackColor = Color.White;
            btncikis.BackColor = Color.White;
            btnrandevukayıt.BackColor = Color.White;
            btnrandevuliste.BackColor = Color.White;
        }

        private void btnhastakayit_Click(object sender, EventArgs e)
        {
            HastaKayit hastakayit = new HastaKayit();
            this.Hide();
            hastakayit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntaburcu_Click(object sender, EventArgs e)
        {
            Taburcu taburcu = new Taburcu();
            this.Hide();
            taburcu.Show();
        }

        private void btnrandevukayıt_Click(object sender, EventArgs e)
        {
            RandevuKayit randevukayıt = new RandevuKayit();
            this.Hide();
            randevukayıt.Show();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            randevuliste randevusorgu = new randevuliste();
            this.Hide();
            randevusorgu.Show();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            bilgigüncelle bilgigünc = new bilgigüncelle();
            this.Hide();
            bilgigünc.Show();
        }

        private void btngörüntüle_Click(object sender, EventArgs e)
        {
            bilgigörüntüle bilgigör = new bilgigörüntüle();
            this.Hide();
            bilgigör.Show();
        }
    }
}
