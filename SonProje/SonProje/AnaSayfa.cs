using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            MusteriEkle fr = new MusteriEkle();
            fr.Show();
            this.Hide();
                            
               
        }

        private void MusteriBilgiBtn_Click(object sender, EventArgs e)
        {
            MusteriGoster fr = new MusteriGoster();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
            this.Hide();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiriseDonme_Click(object sender, EventArgs e)
        {
            AdmnGrs fr = new AdmnGrs();
            fr.Show();
            this.Close();
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            YoneticiEkle fr = new YoneticiEkle();
            fr.Show();  
            this.Hide();
        }

        private void btnResimler_Click(object sender, EventArgs e)
        {
            FormResimler fr = new FormResimler();
            fr.Show();
            this.Hide();
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("121620211072 Yağız Kağan Sarıkan\n121620211058 Hidayet Furkan Dayan","Hakkımızda");
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy \n HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormYorumlar fr = new FormYorumlar();
            fr.Show();
            this.Hide();
        }
    }
}
