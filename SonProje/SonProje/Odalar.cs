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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HPFURKAN\\MSSQLSERVER01;Initial Catalog=gorsel_proje1;Integrated Security=True;TrustServerCertificate=True");
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa();
            fr.Show();
            this.Hide();

        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Oda1", baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();

            while (oku1.Read())
            {
                oda1.Text = oku1["Adi"].ToString() +" "+ oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (oda1.Text != "Oda 1")
            {
                oda1.BackColor = Color.Red;
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
                oda9.Text = "Dolu";
            }



;        }
         
        
        private void oda1_Click(object sender, EventArgs e)
        {
            
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 1", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                

                listView1.Items.Add(ekle);

            }
            baglanti.Close();



        }

        private void oda3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 3", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void oda2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 2", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void oda4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 4", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void oda5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 5", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void oda6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 6", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void oda7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 7", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void oda8_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 8", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void oda9_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where OdaNo= 9", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["OdaNo"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());  //  göre müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
    }
}
