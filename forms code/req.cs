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
    public partial class req : Form
    {
        public req()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT title, COUNT(title) as num_of_sold_Books FROM buyer  GROUP BY title HAVING COUNT(title) = (SELECT MAX(mycount) FROM(SELECT title, COUNT(title) mycount FROM buyer GROUP BY title) as title); ", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void req_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select title From Document Where ( title ) Not In (Select title From buyer); ", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select count(userName) as num_of_authers From Author Where(userName) NOT In(Select AuthorName From buyer) and userName in (select AuthorName from Document) ", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select userName From Author Where ( userName ) Not In (Select AuthorName From Document); ", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT category , COUNT(title) as numberofbooks FROM Document  GROUP BY category HAVING COUNT(title) = ( SELECT min(mycount) FROM( SELECT title, COUNT(title) mycount FROM Document GROUP BY title) as title); ", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=SHROUK;Initial Catalog=libraryproject;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT r.userName,r.password,r.SSN ,COUNT(b.title) AS numberofbooks FROM reader AS r LEFT JOIN buyer AS b ON b.SSN = r.SSN GROUP BY r.userName, r.password, r.SSN; ", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new home();
            h.Show();
        }
    }
}
