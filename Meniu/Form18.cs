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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int aux = 0, k = 0, sw = 0;
            do
            {
                sw = 0;
                for (int i = 0; i < n - k - 1; i++)
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        sw = 1;
                    }
                k++;
            } while (sw == 1);
            for (int i = 0; i < n; i++)
                richTextBox2.Text = richTextBox2.Text + v[i] + " ";
            richTextBox2.Text = richTextBox2.Text + '\n' + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
