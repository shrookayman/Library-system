using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newlibrary1
{
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }

        private void show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryprojectDataSet.Document' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new homeForAdmin();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new home();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.documentTableAdapter.Fill(this.libraryprojectDataSet.Document);

        }
    }
}
