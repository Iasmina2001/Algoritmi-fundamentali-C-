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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public double cmmdc(double a, double b)
        {
            double r = a % b;
            if (a < 0)
                a *= (-1);
            if (b < 0)
                b *= (-1);
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
            int c = Convert.ToInt32(textBox3.Text);
            richTextBox1.Text = richTextBox1.Text + "Pentru a = " + a + " b = " + b + " c = " + c + '\n' + "Ecuatia " + a + " * x^2 + " + b + " * x + " + c + "= 0 are ";
            int d = 0;
            double x1 = 0, x2 = 0;
            if (a != 0)
            {
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    double div = 0;
                    x1 = -b + Math.Round(Math.Sqrt(d), 0);
                    x2 = -b - Math.Round(Math.Sqrt(d), 0);

                    div = cmmdc(x1, 2 * a);
                    x1 /= div;
                    if ((2 * a) / div != 1)
                        richTextBox1.Text = richTextBox1.Text + "x1 = " + x1 + " / " + ((2 * a) / div) + "  ";
                    else
                        richTextBox1.Text = richTextBox1.Text + "x1 = " + x1 + "  ";

                    div = cmmdc(x2, 2 * a);
                    x2 /= div;
                    if ((2 * a) / div != 1)
                        richTextBox1.Text = richTextBox1.Text + "x2 = " + x2 + " / " + ((2 * a) / div);
                    else
                        richTextBox1.Text = richTextBox1.Text + "x2 = " + x2;
                }
                else if (d < 0)
                    richTextBox1.Text = richTextBox1.Text + "o infinitate de solutii";
                else if (d == 0)
                {
                    x1 = Math.Round(Math.Sqrt(d), 0) - b;
                    double div = cmmdc(x1, 2 * a);
                    x1 /= div;
                    if ((2 * a) / div != 1)
                        richTextBox1.Text = richTextBox1.Text + "x1 = x2 = " + x1 + " / " + ((2 * a) / div);
                    else
                        richTextBox1.Text = richTextBox1.Text + "x1 = x2 = " + x1;
                }
            }
            richTextBox1.Text = richTextBox1.Text + '\n' + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
