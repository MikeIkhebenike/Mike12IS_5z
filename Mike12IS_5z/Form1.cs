using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike12IS_5z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h,p, z;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            p = (Math.Pow(a, 2) + Math.Pow(b, 2)) *3;
            z =(Math.PI * h/ 6) * (p+Math.Pow(h,2));
            listBox1.Items.Add("z = "+z+);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
