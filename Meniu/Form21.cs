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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int[] a = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int[] b = richTextBox2.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int[] c = new int[100];

            int i = 0, j = 0, k = 0;
            while (i < n && j < m)
            {
                if (a[i] < b[j])
                    c[k++] = a[i++];
                else if (b[j] < a[i])
                    c[k++] = b[j++];
                else
                {
                    c[k++] = b[j++];
                    i++;
                }
            }
            while (i < n)
                c[k++] = a[i++];
            while (j < m)
                c[k++] = b[j++];
            for (i = 0; i < k; i++)
                richTextBox3.Text = richTextBox3.Text + c[i] + " ";
            richTextBox3.Text = richTextBox3.Text + '\n' + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
