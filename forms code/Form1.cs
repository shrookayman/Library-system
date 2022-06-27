using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newlibrary1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
          //  sqlCommand.CommandText = "INSERT INTO user VALUES (  ' " + textBox3.Text + " ', ' " + textBox1.Text + " ' ,' " + textBox2.Text + " '  ) ";
            sqlCommand.CommandText = "INSERT INTO SingningUp VALUES (  ' " + textBox3.Text + " ', ' " + textBox1.Text + " ' ,' " + textBox2.Text + " '  ) ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            var a = new homeForAdmin();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO SingningUp VALUES (  ' " + textBox3.Text + " ', ' " + textBox1.Text + " ' ,' " + textBox2.Text + " '  ) ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            var h = new home();
            h.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
