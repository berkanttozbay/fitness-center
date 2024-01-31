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

namespace WindowsFormsApp1
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\berka\source\repos\WindowsFormsApp1\WindowsFormsApp1\SporDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillName()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select UAdSoyad from UyeTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt =  new DataTable();
            dt.Columns.Add("UAdSoyad",typeof(string));
            dt.Load(rdr);
            AdSoyadCb.ValueMember= "UAdSoyad";
            AdSoyadCb.DataSource = dt;
            baglanti.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            FillName();
            uyeler();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void AdFiltrele()
        {
            baglanti.Open();
            string query = "select *from OdemeTbl where OUye='"+AraTb.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void CinsiyetTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadCb.Text = "";
            TutarTb.Text = "";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdSoyadCb.Text == "" || TutarTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz.");
            }
            else
            {
                string odemeperiyot = Periyot.Value.Month.ToString() + Periyot.Value.Year.ToString();
                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OdemeTbl where OUye='" + AdSoyadCb.SelectedValue.ToString() + "' and OAy='" + odemeperiyot + "'", baglanti);
                var dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Zaten Ödeme Yapıldı.");
                }
                else
                {
                    string query = "insert into OdemeTbl values('" + odemeperiyot + "','" + AdSoyadCb.SelectedValue.ToString() + "','" + TutarTb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Tutar Basariyla Ödendi.");
                }
                baglanti.Close();
                uyeler();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdFiltrele();
            AraTb.Text = "";
        }

        private void YenileTb_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void AraTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
