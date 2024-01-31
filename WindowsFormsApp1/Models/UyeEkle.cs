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

namespace WindowsFormsApp1
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\berka\source\repos\WindowsFormsApp1\WindowsFormsApp1\SporDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AdSoyadTb.Text=="" || TelefonTb.Text=="" || YasTb.Text=="" || TutarTb.Text=="")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into UyeTbl values('"+AdSoyadTb.Text+"','"+TelefonTb.Text+"','"+CinsiyetTb.SelectedItem.ToString()+"','"+YasTb.Text+"','"+TutarTb.Text+"','"+ZamanlamaTb.SelectedItem.ToString()+ "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Uye Basariyla Eklendi.");
                    baglanti.Close();
                    AdSoyadTb.Text = "";
                    YasTb.Text = "";
                    CinsiyetTb.Text = "";
                    TutarTb.Text = "";
                    TelefonTb.Text = "";
                    ZamanlamaTb.Text = "";
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            YasTb.Text = "";
            CinsiyetTb.Text= "";
            TutarTb.Text = "";
            TelefonTb.Text = "";
            ZamanlamaTb.Text = "";

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {          
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
