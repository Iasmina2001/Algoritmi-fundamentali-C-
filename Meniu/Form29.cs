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
    public partial class Form29 : Form
    {
        public int[] st = new int[100];
        public int n = 0;

        public Form29()
        {
            InitializeComponent();
        }

        int valid(int k)
        {
            for (int i = 1; i < k; i++)
                if (st[k] == st[i])
                    return 0;
            return 1;
        }

        void tip(int k)
        {
            for (int i = 1; i <= k; i++)
                richTextBox1.Text = richTextBox1.Text + st[i] + " ";
            richTextBox1.Text = richTextBox1.Text + '\n';
        }

        void Back(int k)
        {
            for (int i = 1; i <= n; i++)
            {
                st[k] = i;
                if (valid(k) == 1)
                {
                    if (k == n)
                        tip(k);
                    else
                        Back(k + 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            Back(1);
            richTextBox1.Text = richTextBox1.Text + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
