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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();

            richTextBox2.Text = richTextBox2.Text + "Pentru n = " + n + " si vectorul:" + '\n';
            for (int i = 0; i < n; i++)
                richTextBox2.Text = richTextBox2.Text + v[i] + " ";
            richTextBox2.Text = richTextBox2.Text + '\n' + "se va permuta spre stanga" + '\n';
            
            for (int j = 0; j < n; j++)
            {
                int aux = v[0];
                for (int i = 0; i < n; i++)
                    if (i + 1 != n)
                        v[i] = v[i + 1];
                v[n - 1] = aux;
                for (int i = 0; i < n; i++)
                    richTextBox2.Text = richTextBox2.Text + v[i] + " ";
                richTextBox2.Text = richTextBox2.Text + '\n';
            }
            richTextBox2.Text = richTextBox2.Text + '\n';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();

            richTextBox2.Text = richTextBox2.Text + "Pentru n = " + n + " si vectorul:" + '\n';
            for (int i = 0; i < n; i++)
                richTextBox2.Text = richTextBox2.Text + v[i] + " ";
            richTextBox2.Text = richTextBox2.Text + '\n' + "se va permuta spre dreapta" + '\n';

            for (int j = 0; j < n; j++)
            {
                int aux = v[n - 1];
                for (int i = n - 1; i > 0; i--)
                    v[i] = v[i - 1];
                v[0] = aux;
                for (int i = 0; i < n; i++)
                    richTextBox2.Text = richTextBox2.Text + v[i] + " ";
                richTextBox2.Text = richTextBox2.Text + '\n';
            }
        }
    }
}
