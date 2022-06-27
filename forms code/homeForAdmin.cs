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
    public partial class homeForAdmin : Form
    {
        public homeForAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new upload();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new offers();
            h.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new show();
            h.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            var h = new req();
            h.Show();
        }
    }
}
