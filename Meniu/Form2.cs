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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            if (n == 1)
                MessageBox.Show("Nu e prim");
            int sw = 1;     // n e prim
            if (n > 1)
            {
                for (int i = 2; i <= n / 2 && sw == 1; i++)
                    if (n % i == 0)
                        sw = 0;
                if (sw == 0)
                    MessageBox.Show("Nu e prim");
                else
                    MessageBox.Show("E prim");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
