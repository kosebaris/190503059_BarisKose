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
    public partial class MenuSettings : Form
    {
        public MenuSettings()
        {
            InitializeComponent();
        }


        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader dr;

        string[] kodlar = new string[20];


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

        void ProductNameGetir()
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM PRODUCT_TABLE", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();

            while(dr.Read())
            listBox1.Items.Add(dr["ID"].ToString() + " " + dr["NAME"].ToString());


            baglanti.Close();

            
        }

        void ContentGetir(int i)
        {
            
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM PRODUCT_TABLE WHERE ID= '" + kodlar[i] +"'", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();

            while (dr.Read())

                listBox2.Items.Add(dr["ID"].ToString() + " " + dr["NAME"].ToString());


            baglanti.Close();

            i++;


        }




        private void MenuSettings_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            MenuGetir();
            ProductNameGetir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage frm = new MainPage();
            this.Hide();
            frm.Show();
        }

        private void MenuSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_menuyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!listBox2.Items.Contains(listBox1.SelectedItem))
                    listBox2.Items.Add(listBox1.SelectedItem);
                else
                    MessageBox.Show("Bu ürün zaten mevcut");
            }
            catch
            {

            }
        }

        private void btn_menudenCikar_Click(object sender, EventArgs e)
        {
            
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_menutype.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_menuno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_price.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            listBox2.Items.Clear();
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM CONTENT_TABLE WHERE MENU_ID = '"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'", baglanti);
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
                ContentGetir(i-1);
                i--;
            }

        }
    }
}
