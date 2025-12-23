using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoWords
{
    public partial class Kelime_Listesi : Form
    {
        public Kelime_Listesi()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label3.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

            private void Kelime_Listesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ingilizce_kelimeDataSet.kelimeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kelimelerTableAdapter.Fill(this.ingilizce_kelimeDataSet.kelimeler);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kelimeler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kelimeler (ingilizce, türkçe) values(@ing, @tr)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ing", textBox1.Text);
            komut.Parameters.AddWithValue("@tr", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kelimeler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm =new Form1();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update kelimeler set ingilizce =@ing, türkçe = @tr where sıra = @sr",bgl.baglanti());
            komut.Parameters.AddWithValue("@sr", label3.Text);
            komut.Parameters.AddWithValue("@ing", textBox1.Text);
            komut.Parameters.AddWithValue("tr", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Kelimeler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("the word update is successful", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
