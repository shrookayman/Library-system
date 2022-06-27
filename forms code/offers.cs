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
    public partial class offers : Form
    {
        public offers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new homeForAdmin();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE  DOCUMENT  SET  price = ' " + textBox3.Text + " '  WHERE   title = ' " + textBox1.Text + " '  ";
            _ = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("offer updated successfully.");
        }
    }
}
