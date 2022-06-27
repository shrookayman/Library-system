using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newlibrary1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new home();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE  user  SET    username = ' " + textBox3.Text + " ' , password = ' " + textBox4.Text + " '     WHERE   SSN = ' " + textBox5.Text + " '  ";
            sqlCommand.CommandText = "UPDATE  Reader  SET    username = ' " + textBox3.Text + " ' , password = ' " + textBox4.Text + " '     WHERE   SSN = ' " + textBox5.Text + " '  ";

            sqlCommand.CommandText = "UPDATE  SingningUp  SET    username = ' " + textBox3.Text + " ' , password = ' " + textBox4.Text + " '     WHERE   SSN = ' " + textBox5.Text + " '  ";
            _ = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("offer updated successfully.");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
