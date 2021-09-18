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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            richTextBox1.Text = richTextBox1.Text + "Pentru n = " + n + '\n' + "1 ";
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    richTextBox1.Text = richTextBox1.Text + i + " ";
            if (n > 1)
                richTextBox1.Text = richTextBox1.Text + n;
            richTextBox1.Text = richTextBox1.Text + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
