using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Mealbox
{
    public partial class MainPage : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;

        public MainPage()
        {
            InitializeComponent();
        }

        //kullanıcı girişi admin mi eleman mı bilgisi. (fonksiyon kısıtlamalarında kullanılacak.)
        public string loggedas = string.Empty;

        private void MainPage_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM LOGGED_TABLE", baglanti);
            baglanti.Open();

            dr = komut.ExecuteReader();

            dr.Read();
            label1.Text = dr["LOGGEDAS"].ToString();

            baglanti.Close();
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            this.Hide();
            frm.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginPage frm = new LoginPage();
            this.Hide();
            frm.Show();
        }
    }
}
