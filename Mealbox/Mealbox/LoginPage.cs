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
    public partial class LoginPage : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;

        public LoginPage()
        {
            InitializeComponent();
        }


        MainPage mainpageform = new MainPage();
        

        void mainpage()
        {
            
            this.Hide();
            mainpageform.Show();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            string id = textBox_id.Text;
            string pass = textBox_pass.Text;
            


            
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand();

            baglanti.Open();
            komut.Connection = baglanti;
            //admin check
            komut.CommandText = "SELECT * FROM ADMIN_TABLE WHERE ADMINID= '"+textBox_id.Text+"' AND PASS= '"+textBox_pass.Text+"'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                
                string sorgu = "UPDATE LOGGED_TABLE SET LOGGEDAS=@loggedas"; ;
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@loggedas", "Admin");
                komut.ExecuteNonQuery();

                mainpage();

                MessageBox.Show("Admin Girişi Yapıldı");
            }
            else
            {
                dr.Close();
                //employee check
                komut.CommandText = "SELECT * FROM EMPLOYEE_TABLE WHERE EMPLOYEEID= '" + textBox_id.Text + "' AND PASS= '" + textBox_pass.Text + "'";
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();

                    string sorgu = "UPDATE LOGGED_TABLE SET LOGGEDAS=@loggedas"; ;
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@loggedas", "Employee");
                    komut.ExecuteNonQuery();

                    mainpage();

                    MessageBox.Show("Eleman Girişi Yapıldı");
                }
                else
                {
                    MessageBox.Show("Yanlış");
                }
            }

            baglanti.Close();
            dr.Close();



        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
