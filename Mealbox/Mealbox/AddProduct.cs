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
    public partial class AddProduct : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;




        public AddProduct()
        {
            InitializeComponent();
        }


        void ProductGetir()
        {
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM PRODUCT_TABLE", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            ProductGetir();





        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_price.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_imageurl.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


        }

        private void button_add_Click(object sender, EventArgs e)
        {

            string sorgu = "INSERT INTO PRODUCT_TABLE(NAME,PRICE,DESCRIPTION,IMAGEURL) VALUES (@NAME,@PRICE,@DESCRIPTION,@IMAGEURL)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@NAME", textBox_name.Text);
            komut.Parameters.AddWithValue("@PRICE", textBox_price.Text);
            komut.Parameters.AddWithValue("@DESCRIPTION", textBox_description.Text);
            komut.Parameters.AddWithValue("@IMAGEURL", textBox_imageurl.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ProductGetir();

        }

        private void button_remove_Click(object sender, EventArgs e)
        {

            string sorgu = "DELETE FROM PRODUCT_TABLE WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ProductGetir();
            


        }

        private void button_update_Click(object sender, EventArgs e)
        {

            string sorgu = "UPDATE PRODUCT_TABLE SET NAME=@NAME, PRICE=@PRICE, DESCRIPTION=@DESCRIPTION, IMAGEURL=@IMAGEURL WHERE ID=@ID"; ;
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

            komut.Parameters.AddWithValue("@NAME", textBox_name.Text);
            komut.Parameters.AddWithValue("@PRICE", textBox_price.Text);
            komut.Parameters.AddWithValue("@DESCRIPTION", textBox_description.Text);
            komut.Parameters.AddWithValue("@IMAGEURL", textBox_imageurl.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ProductGetir();


        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainPage frm = new MainPage();
            this.Hide();
            frm.Show();
        }
    }
}
