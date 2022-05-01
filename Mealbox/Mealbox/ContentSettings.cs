using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Mealbox
{
    public partial class ContentSettings : Form
    {
        public ContentSettings()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;


        int currentprice = 0;
        int itemsayisi = 0;
        string[] kodlar = new string[20];
        int price = 0;


        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string sayi = Regex.Match(listBox2.SelectedItem.ToString(), @"\d+").Value;
                baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
                komut = new SqlCommand("SELECT * FROM PRODUCT_TABLE WHERE ID= '" + sayi + "'", baglanti);
                baglanti.Open();
                dr = komut.ExecuteReader();
                dr.Read();
                currentprice = currentprice - Int32.Parse(dr["PRICE"].ToString());
                textBox_price.Text = currentprice.ToString();

                listBox2.Items.Remove(listBox2.SelectedItem);
                itemsayisi--;

                baglanti.Close();
            }

            label4.Text = itemsayisi.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string sayi = Regex.Match(listBox1.SelectedItem.ToString(), @"\d+").Value;
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM PRODUCT_TABLE WHERE ID= '" + sayi + "'", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();

            try
            {
                if (!listBox2.Items.Contains(listBox1.SelectedItem))
                {
                    
                    listBox2.Items.Add(listBox1.SelectedItem);
                    itemsayisi++;
                    dr.Read();
                    currentprice = currentprice + Int32.Parse(dr["PRICE"].ToString());
                    textBox_price.Text = currentprice.ToString();
                    

                }

                else
                {
                    MessageBox.Show("Bu ürün zaten mevcut");
                }

            }
            catch
            {

            }


            baglanti.Close();
            label4.Text = itemsayisi.ToString();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MenuSettings frm = new MenuSettings();
            this.Hide();
            frm.Show();
        }

        private void ContentSettings_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            MenuGetir();
            ProductNameGetir();
        }

        void MenuGetir()
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM MENU_TABLE", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;



            baglanti.Close();


        }

        void ContentGetir(int i)
        {

            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM PRODUCT_TABLE WHERE ID= '" + kodlar[i] + "'", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();


            while (dr.Read())
            {
                listBox2.Items.Add(dr["ID"].ToString() + " " + dr["NAME"].ToString());
                price += Int32.Parse(dr["PRICE"].ToString());
            }


            baglanti.Close();

            i++;


        }


        void ProductNameGetir()
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM PRODUCT_TABLE", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())
                listBox1.Items.Add(dr["ID"].ToString() + " " + dr["NAME"].ToString());


            baglanti.Close();


        }

        private void ContentSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentprice = 0;
            
            textBox_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            

            listBox2.Items.Clear();
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM CONTENT_TABLE WHERE MENU_ID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();

            int i = 0;

            while (dr.Read())
            {
                kodlar[i] = dr["PRODUCT_ID"].ToString();
                i++;
            }

            baglanti.Close();

            while (i != 0)
            {
                ContentGetir(i - 1);
                i--;
            }
            //dataGridView1.CurrentRow.Cells[3].Value = price.ToString();
            price = 0;

            dr.Close();
            komut = new SqlCommand("SELECT * FROM MENU_TABLE WHERE ID= '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();
            dr.Read();
            try
            {
                currentprice = Int32.Parse(dr["PRICE"].ToString());
            }
            catch { }

            baglanti.Close();

            
        }

        public void contentEkle()
        {

                string sorgu = "INSERT INTO CONTENT_TABLE(MENU_ID,PRODUCT_ID) VALUES (@MENU_ID,@PRODUCT_ID)";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@MENU_ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());

                string sayi = Regex.Match(listBox1.SelectedItem.ToString(), @"\d+").Value;
                //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                komut.Parameters.AddWithValue("@PRODUCT_ID", sayi);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                

            MenuGetir();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {






        }

        private void button1_Click(object sender, EventArgs e)
        {
            contentEkle();
        }
    }
}
