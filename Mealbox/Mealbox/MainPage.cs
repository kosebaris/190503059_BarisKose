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
            this.Text = "Mealbox";

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

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Admin")
            {
                MenuSettings frm = new MenuSettings();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sie sind nicht zugriffsberechtigt");
            }
        
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CustomerSettings frm = new CustomerSettings();
            this.Hide();
            frm.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Admin")
            {
                EmployeeSettings frm = new EmployeeSettings();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sie sind nicht zugriffsberechtigt");
            }
  
        }
    }
}
