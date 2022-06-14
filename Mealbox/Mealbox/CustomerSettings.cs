using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace Mealbox
{
    public partial class CustomerSettings : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;

        int sonmenuid;


        public CustomerSettings()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainPage frm = new MainPage();
            this.Hide();
            frm.Show();
        }

        private void CustomerSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_lastname.Text = "";
            textBox_kart.Text = "";
            textBox_mobile.Text = "";
            textBox_email.Text = "";
        }

        void MusteriGetir()
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM CUSTOMER_TABLE", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }

        private void CustomerSettings_Load(object sender, EventArgs e)
        {
            this.Text = "Mealbox";

            MusteriGetir();
            listBox1.Items.Clear();
            ListboxDoldur();

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "VORNAME";
            dataGridView1.Columns[2].HeaderText = "NACHNAME";
            dataGridView1.Columns[3].HeaderText = "MOBIL";
            dataGridView1.Columns[4].HeaderText = "EMAIL";
            dataGridView1.Columns[5].HeaderText = "KARTEN-NR";
            dataGridView1.Columns[6].HeaderText = "ADRESSE";
            dataGridView1.Columns[7].HeaderText = "AUSGEWÄHLTES MENÜ";

            dataGridView1.Columns[0].Width = 30;
            //dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[7].Width = 140;

        }

        void ListboxDoldur()
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM MENU_TABLE", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
                listBox1.Items.Add(dr["ID"].ToString());


            baglanti.Close();


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_lastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_mobile.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_kart.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_adres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            /*int rowcount = dataGridView1.Rows.Count - 1;

            sonmenuid = Int32.Parse(dataGridView1.Rows[rowcount].Cells[0].Value.ToString());

            //MessageBox.Show(sonmenuid.ToString());
            */

            listBox1.Items.Clear();
            ListboxDoldur();

            
            int a = 0;

            while (a < listBox1.Items.Count)
            {

                if (Int32.Parse(listBox1.Items[a].ToString()) == Int32.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()))
                listBox1.SelectedIndex = a;

                
                a++;
            }


        }

        private void button_add_Click(object sender, EventArgs e)
        {

            void ekle()
            {
                
                    string sorgu = "INSERT INTO CUSTOMER_TABLE(FIRSTNAME,LASTNAME,PHONENUMBER,EMAIL,KART,ADDRESS,SELECTEDMENU) VALUES (@FIRSTNAME,@LASTNAME,@PHONENUMBER,@EMAIL,@KART,@ADDRESS,@SELECTEDMENU)";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@FIRSTNAME", textBox_name.Text);
                    komut.Parameters.AddWithValue("@LASTNAME", textBox_lastname.Text);
                    komut.Parameters.AddWithValue("@PHONENUMBER", textBox_mobile.Text);
                    komut.Parameters.AddWithValue("@EMAIL", textBox_email.Text);
                    komut.Parameters.AddWithValue("@KART", textBox_kart.Text);
                    komut.Parameters.AddWithValue("@ADDRESS", textBox_adres.Text);
                    komut.Parameters.AddWithValue("@SELECTEDMENU", listBox1.SelectedItem.ToString());
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MusteriGetir();

                    /*SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;

                    string kime = textBox_email.Text;
                    string konu = "Herzlich willkommen";
                    string icerik = "Vielen Dank, dass Sie sich für Mealbox entschieden haben.";

                    sc.Credentials = new NetworkCredential("inf202mealbox@gmail.com", "INF202Mealbox1");
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("inf202mealbox@gmail.com", "Mealbox Project");
                    mail.To.Add(kime);

                    mail.Subject = konu;
                    mail.IsBodyHtml = true;
                    mail.Body = icerik;

                    sc.Send(mail);*/
               
                
            }


            if(textBox_kart.Text.Length == 16)
            {
                if(textBox_mobile.Text.Length == 10)
                {
                    if (IsValidEmail(textBox_email.Text))
                    {
                        ekle();
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
            else
            {
                MessageBox.Show("Die Kartennummer muss 16-stellig sein.");
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


        private void button_update_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE CUSTOMER_TABLE SET FIRSTNAME=@FIRSTNAME, LASTNAME=@LASTNAME, PHONENUMBER=@PHONENUMBER, EMAIL=@EMAIL, KART=@KART, ADDRESS=@ADDRESS, SELECTEDMENU=@SELECTEDMENU WHERE ID=@ID"; ;
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

            komut.Parameters.AddWithValue("@FIRSTNAME", textBox_name.Text);
            komut.Parameters.AddWithValue("@LASTNAME", textBox_lastname.Text);
            komut.Parameters.AddWithValue("@PHONENUMBER", textBox_mobile.Text);
            komut.Parameters.AddWithValue("@EMAIL", textBox_email.Text);
            komut.Parameters.AddWithValue("@KART", textBox_kart.Text);
            komut.Parameters.AddWithValue("@ADDRESS", textBox_adres.Text);
            komut.Parameters.AddWithValue("@SELECTEDMENU", listBox1.SelectedItem.ToString());

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM CUSTOMER_TABLE WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }
    }
}
