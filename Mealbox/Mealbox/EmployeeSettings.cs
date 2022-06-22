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
    public partial class EmployeeSettings : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;

        public EmployeeSettings()
        {
            InitializeComponent();
        }

        private void EmployeeSettings_Load(object sender, EventArgs e)
        {
            this.Text = "Mealbox";
            //radioButton_admin.Checked = true;

            AdminGetir();
            ElemanGetir();

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "VORNAME";
            dataGridView1.Columns[2].HeaderText = "NACHNAME";
            dataGridView1.Columns[3].HeaderText = "MOBIL";
            dataGridView1.Columns[4].HeaderText = "EMAIL";
            dataGridView1.Columns[5].HeaderText = "BENUTZER ID";
            dataGridView1.Columns[6].HeaderText = "TITLE";
            dataGridView1.Columns[7].HeaderText = "PASSWORT";

            dataGridView1.Columns[0].Width = 30;
            //dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 90;
            //dataGridView1.Columns[7].Width = 140;

            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "VORNAME";
            dataGridView2.Columns[2].HeaderText = "NACHNAME";
            dataGridView2.Columns[3].HeaderText = "MOBIL";
            dataGridView2.Columns[4].HeaderText = "EMAIL";
            dataGridView2.Columns[5].HeaderText = "BENUTZER ID";
            dataGridView2.Columns[6].HeaderText = "TITLE";
            dataGridView2.Columns[7].HeaderText = "PASSWORT";

            dataGridView2.Columns[0].Width = 30;
            //dataGridView1.Columns[4].Width = 150;
            dataGridView2.Columns[5].Width = 90;
            //dataGridView1.Columns[7].Width = 140;


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainPage frm = new MainPage();
            this.Hide();
            frm.Show();
        }

        private void EmployeeSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_lastname.Text = "";
            textBox_mobile.Text = "";
            textBox_email.Text = "";
            textBox_id.Text = "";
            textBox_title.Text = "";
            textBox_pass.Text = "";
        }

        void AdminGetir()
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM ADMIN_TABLE", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        void ElemanGetir()
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM EMPLOYEE_TABLE", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_lastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_mobile.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_id.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_title.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox_pass.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            radioButton_admin.Checked = true;
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox_name.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox_lastname.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox_mobile.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox_id.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox_title.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBox_pass.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            radioButton_employee.Checked = true;

        }

        void AdminEkle()
        {
            if (textBox_id.Text.Length == 2)
            {
                string sorgu = "INSERT INTO ADMIN_TABLE(FIRSTNAME,LASTNAME,PHONENUMBER,EMAIL,ADMINID,TITLE,PASS) VALUES (@FIRSTNAME,@LASTNAME,@PHONENUMBER,@EMAIL,@ADMINID,@TITLE,@PASS)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@FIRSTNAME", textBox_name.Text);
                komut.Parameters.AddWithValue("@LASTNAME", textBox_lastname.Text);
                komut.Parameters.AddWithValue("@PHONENUMBER", textBox_mobile.Text);
                komut.Parameters.AddWithValue("@EMAIL", textBox_email.Text);
                komut.Parameters.AddWithValue("@ADMINID", textBox_id.Text);
                komut.Parameters.AddWithValue("@TITLE", textBox_title.Text);
                komut.Parameters.AddWithValue("@PASS", textBox_pass.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                AdminGetir();
            }
            else
            {
                MessageBox.Show("Die Administrator-ID muss zweistellig sein.");
            }
        }

        void ElemanEkle()
        {
            if (textBox_id.Text.Length == 3)
            {
            string sorgu = "INSERT INTO EMPLOYEE_TABLE(FIRSTNAME,LASTNAME,PHONENUMBER,EMAIL,EMPLOYEEID,TITLE,PASS) VALUES (@FIRSTNAME,@LASTNAME,@PHONENUMBER,@EMAIL,@EMPLOYEEID,@TITLE,@PASS)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@FIRSTNAME", textBox_name.Text);
            komut.Parameters.AddWithValue("@LASTNAME", textBox_lastname.Text);
            komut.Parameters.AddWithValue("@PHONENUMBER", textBox_mobile.Text);
            komut.Parameters.AddWithValue("@EMAIL", textBox_email.Text);
            komut.Parameters.AddWithValue("@EMPLOYEEID", textBox_id.Text);
            komut.Parameters.AddWithValue("@TITLE", textBox_title.Text);
            komut.Parameters.AddWithValue("@PASS", textBox_pass.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ElemanGetir();
            }
            else
            {
                MessageBox.Show("Die Employee-ID muss dreistellig sein.");
            }

        }


        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }


        private void button_add_Click(object sender, EventArgs e)
        {

            if (textBox_mobile.Text.Length == 10)
            {
                if (IsValidEmail(textBox_email.Text))
                {
                    if (radioButton_admin.Checked)
                        AdminEkle();

                    if (radioButton_employee.Checked)
                        ElemanEkle();
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse ein.");
                }
            }
            else
            {
                MessageBox.Show("Die Telefonnummer muss 10-stellig sein.");
            }
 
        }

        void AdminGuncelle()
        {

            if (textBox_id.Text.Length == 2)
            {
            string sorgu = "UPDATE ADMIN_TABLE SET FIRSTNAME=@FIRSTNAME, LASTNAME=@LASTNAME, PHONENUMBER=@PHONENUMBER, EMAIL=@EMAIL, ADMINID=@ADMINID, TITLE=@TITLE, PASS=@PASS WHERE ID=@ID"; ;
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

            komut.Parameters.AddWithValue("@FIRSTNAME", textBox_name.Text);
            komut.Parameters.AddWithValue("@LASTNAME", textBox_lastname.Text);
            komut.Parameters.AddWithValue("@PHONENUMBER", textBox_mobile.Text);
            komut.Parameters.AddWithValue("@EMAIL", textBox_email.Text);
            komut.Parameters.AddWithValue("@ADMINID", textBox_id.Text);
            komut.Parameters.AddWithValue("@TITLE", textBox_title.Text);
            komut.Parameters.AddWithValue("@PASS", textBox_pass.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AdminGetir();
            }
            else
            {
                MessageBox.Show("Die Administrator-ID muss zweistellig sein.");
            }

        }

        void ElemanGuncelle()
        {
                if (textBox_id.Text.Length == 3)
                {
                    string sorgu = "UPDATE EMPLOYEE_TABLE SET FIRSTNAME=@FIRSTNAME, LASTNAME=@LASTNAME, PHONENUMBER=@PHONENUMBER, EMAIL=@EMAIL, EMPLOYEEID=@EMPLOYEEID, TITLE=@TITLE, PASS=@PASS WHERE ID=@ID"; ;
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()));

                    komut.Parameters.AddWithValue("@FIRSTNAME", textBox_name.Text);
                    komut.Parameters.AddWithValue("@LASTNAME", textBox_lastname.Text);
                    komut.Parameters.AddWithValue("@PHONENUMBER", textBox_mobile.Text);
                    komut.Parameters.AddWithValue("@EMAIL", textBox_email.Text);
                    komut.Parameters.AddWithValue("@EMPLOYEEID", textBox_id.Text);
                    komut.Parameters.AddWithValue("@TITLE", textBox_title.Text);
                    komut.Parameters.AddWithValue("@PASS", textBox_pass.Text);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    ElemanGetir();
                }
                else
                {
                    MessageBox.Show("Die Employee-ID muss dreistellig sein.");
                }

        }



        private void button_update_Click(object sender, EventArgs e)
        {
            
            if (textBox_mobile.Text.Length == 10)
            {
                if (IsValidEmail(textBox_email.Text))
                {
                    if (radioButton_admin.Checked)
                    {
                        if (!adminMevcutMu())
                            AdminGuncelle();
                        else
                            MessageBox.Show("Es gibt einen anderen Administrator mit derselben Benutzer-ID.");
                    }
                        

                    if (radioButton_employee.Checked)
                    {
                        if (!elemanMevcutMu())
                            ElemanGuncelle();
                        else
                            MessageBox.Show("Es gibt einen anderen Mitarbeiter mit derselben Benutzer-ID.");
                    }
                        
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse ein.");
                }
            }
            else
            {
                MessageBox.Show("Die Telefonnummer muss 10-stellig sein.");
            }


        }

        private void radioButton_employee_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text.Length != 3)
            {
                radioButton_employee.Checked = false;
            }

        }

        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_id.Text.Length != 2)
            {
                radioButton_admin.Checked = false;
            }
        }




        void AdminSil()
        {
            string sorgu = "DELETE FROM ADMIN_TABLE WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AdminGetir();

        }

        void ElemanSil()
        {
            string sorgu = "DELETE FROM EMPLOYEE_TABLE WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ElemanGetir();

        }


        private void button_remove_Click(object sender, EventArgs e)
        {
            if (radioButton_admin.Checked)
                AdminSil();

            if (radioButton_employee.Checked)
                ElemanSil();
        }


        bool adminMevcutMu()
        {
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM ADMIN_TABLE WHERE (ADMINID = @ADMINID)", baglanti);
            check_User_Name.Parameters.AddWithValue("@ADMINID", textBox_id.Text);
            baglanti.Open();
            int UserExist = (int)check_User_Name.ExecuteScalar();
            baglanti.Close();

            if (UserExist > 0)
            {
                if (textBox_id.Text == dataGridView1.CurrentRow.Cells[5].Value.ToString())
                {
                    return false;
                }
                
                return true;
            }
            else
            {
                return false;
            }
            
        }

        bool elemanMevcutMu()
        {

            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM EMPLOYEE_TABLE WHERE (EMPLOYEEID = @EMPLOYEEID)", baglanti);
            check_User_Name.Parameters.AddWithValue("@EMPLOYEEID", textBox_id.Text);
            baglanti.Open();
            int UserExist = (int)check_User_Name.ExecuteScalar();
            baglanti.Close();

            if (UserExist > 0)
            {
                
                if (textBox_id.Text == dataGridView2.CurrentRow.Cells[5].Value.ToString())
                {
                    return false;
                }
                
                return true;
            }
            else
            {
                return false;
            }
            
        }



    }
}
