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


namespace newlibrary1
{
    public partial class ideas : Form
    {
        public ideas()
        {
            InitializeComponent();
        }

        private void ideas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryprojectDataSet.sharingIdeas' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.sharingIdeasTableAdapter.Fill(this.libraryprojectDataSet.sharingIdeas);

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
            sqlCommand.CommandText = "INSERT INTO sharingIdeas VALUES (  ' " + textBox1.Text + " ' ,' " + textBox2.Text + " ' ,' " + textBox4.Text + " ' ) ";
            _ = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("your feedback is sent.");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
