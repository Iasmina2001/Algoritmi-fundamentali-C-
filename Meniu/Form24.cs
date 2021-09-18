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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int p = Convert.ToInt32(textBox2.Text);
            int[] v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();

            for (int i = p; i < n; i++)
                if (i + 1 != n)
                    v[i] = v[i + 1];
            
            n--;
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
