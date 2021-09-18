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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private int prime(int a, int b)
        {
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            if (b == 1)
                return 1;       // Sunt prime intre ele
            return 0;
        }

        public int[] v = new int[100];

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            var lista = new List<int>();
            for (int i = 0; i < n; i++)
                lista.Add(v[i]);
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                    if (prime(v[i], v[j]) == 1)
                        richTextBox2.Text = richTextBox2.Text + v[i] + " " + v[j] + '\n';
            }
            richTextBox2.Text = richTextBox2.Text + '\n';
        }
    }
}
