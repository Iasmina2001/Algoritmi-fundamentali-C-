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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int aux = 0;

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }

            for (int i = 0; i < n; i++)
                richTextBox2.Text = richTextBox2.Text + v[i] + " ";
            richTextBox2.Text = richTextBox2.Text + '\n' + '\n';
        }
    }
}
