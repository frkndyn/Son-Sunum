using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SonProje
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HPFURKAN\\MSSQLSERVER01;Initial Catalog=gorsel_proje1;Integrated Security=True;TrustServerCertificate=True");

        private void oda1_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text +"')",baglanti) ;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void oda2_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "2";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda2 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda3_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "3";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda3 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void oda4_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "4";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda4 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda5_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "5";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda5 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda6_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "6";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda6 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda7_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "7";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda7 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda8_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "8";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda8 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void oda9_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "9";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda9 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void bosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş Odaları Gösterir");

        }

        private void doluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolu Odaları Gösterir");
        }

        private void dateTimePickerCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret,kiyas;
            DateTime ktarih = Convert.ToDateTime(dateTimePickerGiris.Text);

            DateTime btarih = Convert.ToDateTime(dateTimePickerCikis.Text);

            TimeSpan sonuc = btarih - ktarih; // İki tarih arasındaki sonuç
            kiyas = DateTime.Compare(btarih,ktarih);

            if (kiyas < 0)
            {
                MessageBox.Show("Çıkış Tarihi Giriş Tarihinden Önce Olamaz.");
                txtUcret.Text = " ";
                GunLabel.Text = " ";
                
            }
            else {

                GunLabel.Text = sonuc.TotalDays.ToString(); // iki tarih arasındaki gün
                ucret = Convert.ToInt32(GunLabel.Text) * 500;  // günlük ücret ile kalınan günü çarpar
                txtUcret.Text = ucret.ToString(); // ücreti yazar

            }

            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi, Soyadi, Cinsiyet, Telefon, TcNo, Ucret, OdaNo ,GirisTarihi, CikisTarihi) values "+
                    "('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + comboBox1.Text + "','" + maskedTextBox1.Text + "','" + txtTcNo.Text + 
                    "','" + txtUcret.Text + "','" + txtOdaNo.Text + "','" + dateTimePickerGiris.Value.ToString("yyyy-MM-dd") +
                     "','" + dateTimePickerCikis.Value.ToString("yyyy-MM-dd")+"')" , baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Başarıyla Yapıldı.");

        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            // oda 1
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda1", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                oda1.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda1.Text != "Oda 1")
            {
                oda1.BackColor = Color.Red;
                oda1.Enabled = false;
                oda1.Text = "Dolu";
            }


            // oda 2
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda2", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                oda2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda2.Text != "Oda 2")
            {
                oda2.BackColor = Color.Red;
                oda2.Enabled = false;
                oda2.Text = "Dolu";
            }


            // oda 3 

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda3", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                oda3.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda3.Text != "Oda 3")
            {
                oda3.BackColor = Color.Red;
                oda3.Enabled = false;
                oda3.Text = "Dolu";
            }

            // oda 4
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda4", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                oda4.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda4.Text != "Oda 4")
            {
                oda4.BackColor = Color.Red;
                oda4.Enabled = false;
                oda4.Text = "Dolu";
            }

            // oda 5

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda5", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                oda5.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda5.Text != "Oda 5")
            {
                oda5.BackColor = Color.Red;
                oda5.Enabled = false;
                oda5.Text = "Dolu";
            }

            // oda 6

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda6", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                oda6.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda6.Text != "Oda 6")
            {
                oda6.BackColor = Color.Red;
                oda6.Enabled = false;
                oda6.Text = "Dolu";
            }

            // oda 7 

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda7", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                oda7.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda7.Text != "Oda 7")
            {
                oda7.BackColor = Color.Red;
                oda7.Enabled = false;
                oda7.Text = "Dolu";
            }


            // oda 8 

            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda8", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                oda8.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda8.Text != "Oda 8")
            {
                oda8.BackColor = Color.Red;
                oda8.Enabled = false;
                oda8.Text = "Dolu";
            }

            // oda 9 

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda9", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                oda9.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda9.Text != "Oda 9")
            {
                oda9.BackColor = Color.Red;
                oda9.Enabled = false;
                oda9.Text = "Dolu";
            }


        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa();
            fr.Show();
            this.Close();
        }

        private void GunLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

    // Data Source=HPFURKAN\MSSQLSERVER01;Initial Catalog=gorsel_proje1;Integrated Security=True;Trust Server Certificate=True

