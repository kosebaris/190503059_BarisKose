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

namespace Mealbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person personObject = new Person();
            personObject.FirstName = textBox1.Text;
            listBox1.Items.Add(personObject.FirstName);
            label1.Text = personObject.FirstName;

            
            
        }



        SqlConnection baglanti = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = db_mealbox; Integrated Security = True");

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State.ToString() == "Closed")
            {
                baglanti.Open();
                MessageBox.Show("Open");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            MessageBox.Show("Close");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baglanti.State.ToString());
        }
    }
}
