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
    public partial class MusteriGoster : Form
    {
        public MusteriGoster()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HPFURKAN\\MSSQLSERVER01;Initial Catalog=gorsel_proje1;Integrated Security=True;TrustServerCertificate=True");

        private void musterigoster()
        {
            listView1.Items.Clear(); // elemanları sürekli tekrarlatmaz sürekli siler yeniden yazar.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader(); // verileri okuması için yazdık.

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();   // id yi ana veri olarak alıp gerisini id üzerinden getireceğiz.
                ekle.SubItems.Add(oku["Adi"].ToString());  // id ye müşteri adını gösterecek olan kod.
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TcNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle); // listeye ekledeki elemanları getirecek olan kod.


            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            musterigoster();// üst tarafta yazdığımız kodları çağırdık.
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);  //id yi hafızada tutar ona göre işleme devam eder. Ana kaynak burda id tutulmuş olur.
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text; // id ye göre ismi yazdırma.
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtTcNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dateTimePickerGiris.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePickerCikis.Text = listView1.SelectedItems[0].SubItems[9].Text;
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            baglanti.Open();

              SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);  // id si seçili müşteriyi silme komutu
              komut.ExecuteNonQuery();
              baglanti.Close();
              if (txtOdaNo.Text== "1")
            {
                baglanti.Open();
                SqlCommand komutsil1 = new SqlCommand("delete from Oda1", baglanti);
                komutsil1.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNo.Text == "2")
            {
                baglanti.Open();
                SqlCommand komutsil2= new SqlCommand("delete from Oda2",baglanti);
                komutsil2.ExecuteNonQuery();
                baglanti.Close();
            }

            if (txtOdaNo.Text == "3")
            {
                baglanti.Open();
                SqlCommand komutsil3 = new SqlCommand("delete from Oda3", baglanti);
                komutsil3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNo.Text == "4")
            {
                baglanti.Open();
                SqlCommand komutsil4 = new SqlCommand("delete from Oda4", baglanti);
                komutsil4.ExecuteNonQuery();
                baglanti.Close();
            }

            if (txtOdaNo.Text == "5")
            {
                baglanti.Open();
                SqlCommand komutsil5 = new SqlCommand("delete from Oda5", baglanti);
                komutsil5.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNo.Text == "6")
            {
                baglanti.Open();
                SqlCommand komutsil6 = new SqlCommand("delete from Oda6", baglanti);
                komutsil6.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNo.Text == "7")
            {
                baglanti.Open();
                SqlCommand komutsil7 = new SqlCommand("delete from Oda7", baglanti);
                komutsil7.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNo.Text == "8")
            {
                baglanti.Open();
                SqlCommand komutsil8 = new SqlCommand("delete from Oda8", baglanti);
                komutsil8.ExecuteNonQuery();
                baglanti.Close();
            }
            if (txtOdaNo.Text == "9")
            {
                baglanti.Open();
                SqlCommand komutsil9 = new SqlCommand("delete from Oda9", baglanti);
                komutsil9.ExecuteNonQuery();
                baglanti.Close();
            }



            // textbox da kalan yazıları bu komutlarla siliyoruz.
            txtAdi.Clear();
            txtSoyadi.Clear();
            comboBox1.Text = "";
            txtTcNo.Clear();
            maskedTextBox1.Text = "";
            txtUcret.Clear();
            txtOdaNo.Clear();
            dateTimePickerGiris.Text = "";
            dateTimePickerCikis.Text = "";
            MessageBox.Show("Başarıyla Silindi");
            musterigoster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+txtAdi.Text+"',Soyadi='"+txtSoyadi.Text+"',Cinsiyet='"+comboBox1.Text+"',Telefon='"+maskedTextBox1.Text+
                "',TcNo='"+txtTcNo.Text+"',Ucret='"+txtUcret.Text+"',OdaNo='"+txtOdaNo.Text+"',GirisTarihi='"+dateTimePickerGiris.Value.ToString("yyyy-MM-dd")+
                "',CikisTarihi='"+dateTimePickerCikis.Value.ToString("yyyy-MM-dd") + "'where Musteriid=" + id +"", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            musterigoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + txtArama.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader(); 

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();   
                ekle.SubItems.Add(oku["Adi"].ToString());  
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TcNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);


            }

            baglanti.Close();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa();
            fr.Show();
            this.Close();
        }
    }
}























// Data Source=HPFURKAN\MSSQLSERVER01;Initial Catalog=gorsel_proje1;Integrated Security=True;Trust Server Certificate=True
// Data Source=HPFURKAN\MSSQLSERVER01;Initial Catalog=gorsel_proje1;Integrated Security=True;Trust Server Certificate=True
// Bu bağlantı adresi. Veri tabanını bağlamak için aldık.

// SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);

//   for(int i =1; i<= 9; i++)
//        {

//          if (txtOdaNo.Text == i.ToString())
//        {


//      }
//}


//         baglanti.Open();

//
//           SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);  // id si seçili müşteriyi silme komutu

//   komut.ExecuteNonQuery();

// baglanti.Close();
