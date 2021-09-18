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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int[] v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int[] v2 = richTextBox2.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int[] intersectie = new int[200];
            int k = 0;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (v[i] == v2[j])
                    {
                        intersectie[k] = v[i];
                        k++;
                    }
            if (k == 0)
                richTextBox3.Text = richTextBox3.Text + "Multime vida";
            else
                for (int i = 0; i < k; i++)
                    richTextBox3.Text = richTextBox3.Text + intersectie[i] + " ";
            richTextBox3.Text = richTextBox3.Text + '\n' + '\n';
        }
    }
}
