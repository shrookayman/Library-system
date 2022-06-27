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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryprojectDataSet.Document' table. You can move, or remove it, as needed.

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //this.documentTableAdapter.Fill(this.libraryprojectDataSet.Document);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *   FROM Document  WHERE  title = ' " + textBox3.Text + " ' ; ", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new home();
            h.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
