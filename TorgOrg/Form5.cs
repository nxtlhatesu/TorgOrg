using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorgOrg
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 b = new Form2();
            b.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 d = new Form4();
            d.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Visible = true;

        }
    }
}
