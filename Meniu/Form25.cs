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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int sw = 1;
            for (int i = 0; i < n - 1 && sw == 1; i++)
                for (int j = i + 1; j <= n - 1 && sw == 1; j++)
                    if (v[i] == v[j])
                        sw = 0;
            if (sw == 1)
                MessageBox.Show("Da");
            else
                MessageBox.Show("Nu");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
