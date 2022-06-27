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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new Form2();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new ideas();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new show();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new view();
            h.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new buy();
            h.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new req();
            h.Show();
        }
    }
}
