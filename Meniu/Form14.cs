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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            richTextBox1.Text = richTextBox1.Text + "n = ";
            int fact = 2, p = 0;
            while (n != 1)
            {
                p = 0;
                while (n % fact == 0)
                {
                    p++;
                    n /= fact;
                }
                if (p != 0)
                    richTextBox1.Text = richTextBox1.Text + fact + "^" + p + " * ";
                if (fact == 2)
                    fact = 3;
                else
                    fact += 2;
            }
            richTextBox1.Text = richTextBox1.Text + "1" + '\n' + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
