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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int[] a = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int[] b = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();

            int sw = 0;
            for (int i = 0; i < n; i++)
            {
                sw = 0;
                for (int j = 0; j < m; j++)
                    if (a[i] == b[j])
                        sw = 1;
                if (sw == 0)
                    richTextBox3.Text = richTextBox3.Text + a[i] + " ";
            }
            richTextBox3.Text = richTextBox3.Text + '\n' + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
