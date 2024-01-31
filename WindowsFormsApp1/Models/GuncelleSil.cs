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
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\berka\source\repos\WindowsFormsApp1\WindowsFormsApp1\SporDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Eğer geçerli bir satır tıklandıysa
            {
                key = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                AdSoyadTb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TelefonTb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                CinsiyetTb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                YasTb.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                TutarTb.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                ZamanlamaTb.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if(key== 0)
            {
                MessageBox.Show("Silinecek uyeyi seciniz.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from UyeTbl where UId=" + key + ";";                   
                    SqlCommand komut = new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Uye Silindi");
                    baglanti.Close();
                    uyeler();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            YasTb.Text = "";
            CinsiyetTb.Text = "";
            TutarTb.Text = "";
            TelefonTb.Text = "";
            ZamanlamaTb.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdSoyadTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || AdSoyadTb.Text == ""||  TelefonTb.Text == "" || YasTb.Text == "" || TutarTb.Text == "" || ZamanlamaTb.Text == ""||CinsiyetTb.Text =="")
            {
                MessageBox.Show("Eksik Bilgi.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update UyeTbl set UAdSoyad='" + AdSoyadTb.Text + "',UTelefon='" + TelefonTb.Text + "',UCinsiyet='" + CinsiyetTb.Text + "',UYas='" + YasTb.Text + "',UOdeme='" + TutarTb.Text + "',UZamanlama='" + ZamanlamaTb.Text + "' where UId=" + key + ";"; 
                        
                    SqlCommand komut = new SqlCommand(query, baglanti);                    
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Uye Guncellendi.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
