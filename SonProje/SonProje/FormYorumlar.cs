using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SonProje.Properties;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SonProje
{
    public partial class FormYorumlar : Form
    {
        public FormYorumlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HPFURKAN\\MSSQLSERVER01;Initial Catalog=gorsel_proje1;Integrated Security=True;TrustServerCertificate=True");
        private void pbYildiz5_Click(object sender, EventArgs e)
        {
            pbYildiz1.Image = Resources.icons8_star_48;
            pbYildiz2.Image = Resources.icons8_star_48;
            pbYildiz3.Image = Resources.icons8_star_48;
            pbYildiz4.Image = Resources.icons8_star_48;
            pbYildiz5.Image = Resources.icons8_star_48;
            labelPuan.Text = "5";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Puanlar(Puan) values('"+labelPuan.Text+ "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void pbYildiz4_Click(object sender, EventArgs e)
        {
            pbYildiz5.Image = Resources.icons8_star_48_1_;
            pbYildiz1.Image = Resources.icons8_star_48;
            pbYildiz2.Image = Resources.icons8_star_48;
            pbYildiz3.Image = Resources.icons8_star_48;
            pbYildiz4.Image = Resources.icons8_star_48;
            labelPuan.Text = "4";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Puanlar(Puan) values('" + labelPuan.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void pbYildiz3_Click(object sender, EventArgs e)
        {
            pbYildiz5.Image = Resources.icons8_star_48_1_;
            pbYildiz4.Image = Resources.icons8_star_48_1_;
            pbYildiz1.Image = Resources.icons8_star_48;
            pbYildiz2.Image = Resources.icons8_star_48;
            pbYildiz3.Image = Resources.icons8_star_48;
            labelPuan.Text = "3";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Puanlar(Puan) values('" + labelPuan.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void pbYildiz2_Click(object sender, EventArgs e)
        {
            pbYildiz5.Image = Resources.icons8_star_48_1_;
            pbYildiz4.Image = Resources.icons8_star_48_1_;
            pbYildiz3.Image = Resources.icons8_star_48_1_;
            pbYildiz1.Image = Resources.icons8_star_48;
            pbYildiz2.Image = Resources.icons8_star_48;
            labelPuan.Text = "2";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Puanlar(Puan) values('" + labelPuan.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void pbYildiz1_Click(object sender, EventArgs e)
        {
            pbYildiz5.Image = Resources.icons8_star_48_1_;
            pbYildiz4.Image = Resources.icons8_star_48_1_;
            pbYildiz3.Image = Resources.icons8_star_48_1_;
            pbYildiz2.Image = Resources.icons8_star_48_1_;
            pbYildiz1.Image = Resources.icons8_star_48;
            labelPuan.Text = "1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Puanlar(Puan) values('" + labelPuan.Text + "')", baglanti);
            komut.ExecuteNonQuery();
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
