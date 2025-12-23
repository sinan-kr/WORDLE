using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace MemoWords
{
    public partial class Kelimeegzersiz : Form
    {
        public Kelimeegzersiz()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }


        private void Kelimeegzersiz_Load(object sender, EventArgs e)
        {
            //kelime sayısını bulma
            SqlCommand komut = new SqlCommand("select count (*) from Kelimeler", bgl.baglanti());
            int satirsayisi = (int)komut.ExecuteScalar();

            //rastgele sayı üretme
            Random rnd = new Random();
            int klmsys = rnd.Next(0, satirsayisi + 1);

            //rastgele kelime getirme
            SqlCommand komut2 = new SqlCommand("select * from Kelimeler where sıra = @p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", klmsys);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[1].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {                                   
            SqlCommand komut3 = new SqlCommand("SELECT türkçe FROM Kelimeler WHERE ingilizce = @ingilizce", bgl.baglanti());
            komut3.Parameters.AddWithValue("@ingilizce", label1.Text);

            SqlDataReader dr = komut3.ExecuteReader();
            if (dr.Read())
            {

                //kelime kontrolü
                if (textBox1.Text.Trim().ToLower() == dr["türkçe"].ToString().Trim().ToLower())
                {
                    MessageBox.Show("Congratulations", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong, Answer: " + dr["türkçe"].ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBox1.Text = "";

                //kelime sayısını bulma
                SqlCommand komut = new SqlCommand("select count (*) from Kelimeler", bgl.baglanti());
                int satirsayisi = (int)komut.ExecuteScalar();

                //rastgele sayı üretme
                Random rnd = new Random();
                int klmsys = rnd.Next(0, satirsayisi + 1);

                //rastgele kelime getirme
                SqlCommand komut2 = new SqlCommand("select * from Kelimeler where sıra = @p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", klmsys);
                SqlDataReader dr1 = komut2.ExecuteReader();
                while (dr1.Read())
                {
                    label1.Text = dr1[1].ToString();

                }

            }
        }
    }
}
