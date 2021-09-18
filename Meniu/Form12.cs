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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        public int cmmdc(int a, int b)
        {
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            richTextBox1.Text = richTextBox1.Text + "Pentru a = " + a + " si b = " + b + '\n' + "Ecuatia " + a + " * x + " + b + " = 0 are solutia x = ";
            if (a != 0)
            {
                int div = cmmdc(a, b);
                b = b / div;
                a = a / div;
                richTextBox1.Text = richTextBox1.Text + "-" + b + " / " + a;
            }
            else if (b != 0)
                richTextBox1.Text = richTextBox1.Text + "Imposibil";
            else
                richTextBox1.Text = richTextBox1.Text + "O infinitate de solutii";
            richTextBox1.Text = richTextBox1.Text + '\n' + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
