using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SonProje
{
    public partial class AdmnGrs : Form
    {
        public AdmnGrs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HPFURKAN\\MSSQLSERVER01;Initial Catalog=gorsel_proje1;Integrated Security=True;TrustServerCertificate=True");
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            

                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@KullaniciAdi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", txtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();  // sanal tablo kurduk

                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    AnaSayfa fr = new AnaSayfa();
                    fr.Show();
                this.Hide();
                    
                }
                else {
                    
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                
                }
                baglanti.Close();
            }

            



        

        private void AdmnGrs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                BtnGiris.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
