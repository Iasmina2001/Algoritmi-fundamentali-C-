using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meniu
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);
            int aux2 = 0, aux4 = 0, r = 0, cmmdc = 0, cmmmc = 0, n1 = 0, n2 = 0;
            aux2 = b;
            aux4 = d;
            r = b % d;
            while (r != 0)
            {
                b = d;
                d = r;
                r = b % d;
            }
            cmmdc = d;
            cmmmc = (aux2 * aux4) / cmmdc;
            n1 = a * (cmmmc / aux2);
            n2 = c * (cmmmc / aux4);
            MessageBox.Show("" + (n1 + n2) + " / " + cmmmc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
