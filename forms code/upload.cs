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
    public partial class upload : Form
    {
        public upload()
        {
            InitializeComponent();
        }

        private void upload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryprojectDataSet.Document' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO DOCUMENT VALUES (  ' " + textBox1.Text + " ', ' " + textBox2.Text + " ' ,' " + textBox3.Text + " ' ,' " + textBox4.Text + " ' ,' " + textBox5.Text + " ' ,' " + textBox6.Text + " ' ,' " + textBox7.Text + " '  ) ";
            _ = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("content updated successfully.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.documentTableAdapter.Fill(this.libraryprojectDataSet.Document);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new homeForAdmin();
            h.Show();
        }
    }
}
