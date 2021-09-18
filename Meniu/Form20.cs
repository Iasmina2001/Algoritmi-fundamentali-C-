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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int k = 0;
            int[] a = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int[] b = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int[] reuniune = new int[100];

            for (int i = 0; i < n; i++)
                reuniune[i] = a[i];

            k = n - 1;
            for (int j = 0; j < m; j++)
            {
                if (j + 1 != m)
                {
                    int sw = 1;
                    for (int i = 0; i < n && sw == 1; i++)
                        if (b[j] == a[i] && (i + 1 != n))
                            sw = 0;
                    if (sw == 1)
                    {
                        Array.Resize(ref reuniune, k + 1);
                        k++;
                        reuniune[k] = b[j];
                    }
                }
            }

            for (int i = 0; i < k; i++)
                richTextBox3.Text = richTextBox3.Text + reuniune[i] + " ";
            richTextBox3.Text = richTextBox3.Text + '\n' + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
