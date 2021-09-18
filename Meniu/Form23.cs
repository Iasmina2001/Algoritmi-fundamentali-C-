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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int x = Convert.ToInt32(textBox2.Text);
            int p = Convert.ToInt32(textBox3.Text);
            int[] a = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();

            Array.Resize(ref a, n + 1);
            int i = n;
            a[n] = -1;
            while (i != p)
            {
                a[i] = a[i - 1];
                i--;
            }
            a[p] = x;
            for (i = 0; i <= n; i++)
                richTextBox2.Text = richTextBox2.Text + a[i] + " ";
            richTextBox2.Text = richTextBox2.Text + '\n' + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
