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
        int price = 0;
        int currentprice = 0;
        int itemsayisi = 0;


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
            {
                listBox3.Items.Add(dr["ID"].ToString() + " " + dr["NAME"].ToString());
                price += Int32.Parse(dr["PRICE"].ToString());
            }
            
            
            baglanti.Close();

            i++;


        }




        private void MenuSettings_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
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
            string sorgu = "INSERT INTO MENU_TABLE(MENUTYPE,MENUNO,PRICE,DESCRIPTION) VALUES (@MENUTYPE,@MENUNO,@PRICE,@DESCRIPTION)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MENUTYPE", textBox_menutype.Text);
            komut.Parameters.AddWithValue("@MENUNO", textBox_menuno.Text);
            komut.Parameters.AddWithValue("@PRICE", textBox_price.Text);
            komut.Parameters.AddWithValue("@DESCRIPTION", textBox_description.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();



            MenuGetir();
            //addContent();
            itemsayisi = 0;
            

            /*textBox_menutype.Text = "";
            textBox_menuno.Text = "";
            textBox_price.Text = "";
            textBox_description.Text = "";
            listBox3.Items.Clear();*/


        }

        int getitemsayisi()
        {

            return listBox3.Items.Count;

        }

        public void contentEkle()
        {
            int datarowcount = 0;
            
            datarowcount = dataGridView1.Rows.Count - 1;

            
            int a = 0;

            

            while (a < itemsayisi - 1)
            {
                string sorgu = "INSERT INTO CONTENT_TABLE(MENU_ID,PRODUCT_ID) VALUES (@MENU_ID,@PRODUCT_ID)";
                komut = new SqlCommand(sorgu, baglanti);
                
                    komut.Parameters.AddWithValue("@MENU_ID", dataGridView1.Rows[datarowcount].Cells[0].Value.ToString());

                 string sayi = Regex.Match(listBox3.Items[a].ToString(), @"\d+").Value;
               MessageBox.Show(listBox3.Items[0].ToString());
   
                komut.Parameters.AddWithValue("@PRODUCT_ID", sayi);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                a++;
            }

            MenuGetir();
        }

        void addContent()
        {

            int datarowcount = 0;

            datarowcount = dataGridView1.Rows.Count - 1;


            int a = 0;



            while (a < itemsayisi - 1)
            {
                string sorgu = "INSERT INTO CONTENT_TABLE(MENU_ID,PRODUCT_ID) VALUES (@MENU_ID,@PRODUCT_ID)";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@MENU_ID", dataGridView1.Rows[datarowcount].Cells[0].Value.ToString());

                string sayi = Regex.Match(listBox3.Items[a].ToString(), @"\d+").Value;
                // MessageBox.Show(listBox3.Items[0].ToString());

                komut.Parameters.AddWithValue("@PRODUCT_ID", sayi);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                a++;
            }

            MenuGetir();
        



    }




        private void btn_menuyeEkle_Click(object sender, EventArgs e)
        {
            string sayi = Regex.Match(listBox1.SelectedItem.ToString(), @"\d+").Value;
            baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
            komut = new SqlCommand("SELECT * FROM PRODUCT_TABLE WHERE ID= '" + sayi + "'", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();

            try
            {
                if (!listBox3.Items.Contains(listBox1.SelectedItem))
                {
                    listBox3.Items.Add(listBox1.SelectedItem);
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

            //MessageBox.Show(currentprice.ToString());

        }

        private void btn_menudenCikar_Click(object sender, EventArgs e)
        {

            if (listBox3.SelectedItem != null)
            {
                string sayi = Regex.Match(listBox3.SelectedItem.ToString(), @"\d+").Value;
                baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");
                komut = new SqlCommand("SELECT * FROM PRODUCT_TABLE WHERE ID= '" + sayi + "'", baglanti);
                baglanti.Open();
                dr = komut.ExecuteReader();
                dr.Read();
                currentprice = currentprice - Int32.Parse(dr["PRICE"].ToString());
                textBox_price.Text = currentprice.ToString();

                listBox3.Items.Remove(listBox3.SelectedItem);
                itemsayisi--;

                baglanti.Close();
            }

            //MessageBox.Show(currentprice.ToString());
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentprice = 0;
            textBox_menutype.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_menuno.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_description.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            listBox3.Items.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            textBox_menutype.Text = "";
            textBox_menuno.Text = "";
            textBox_description.Text = "";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            addContent();
        }

        string itemisimleri(int i)
        {

            return listBox3.Items[i].ToString();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM MENU_TABLE WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MenuGetir();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE MENU_TABLE SET MENUTYPE=@MENUTYPE, MENUNO=@MENUNO, PRICE=@PRICE, DESCRIPTION=@DESCRIPTION WHERE ID=@ID"; ;
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

            komut.Parameters.AddWithValue("@MENUTYPE", textBox_menutype.Text);
            komut.Parameters.AddWithValue("@MENUNO", textBox_menuno.Text);
            komut.Parameters.AddWithValue("@PRICE", textBox_price.Text);
            komut.Parameters.AddWithValue("@DESCRIPTION", textBox_description.Text);
            

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MenuGetir();
        }

        private void btn_addcontent_Click(object sender, EventArgs e)
        {
            ContentSettings frm = new ContentSettings();
            this.Hide();
            frm.Show();
        }
    }
}
