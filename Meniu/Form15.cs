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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int N1 = Convert.ToInt32(textBox2.Text);
            int aux1 = 0, aux2 = 0, r = 0, n2 = 0, N2 = 0;
            aux1 = n1;
            aux2 = N1;
            r = n1 % N1;
            while (r != 0)
            {
                n1 = N1;
                N1 = r;
                r = n1 % N1;
            }
            n2 = aux1 / N1;
            N2 = aux2 / N1;
            if (N2 != 1)
                MessageBox.Show("" + n2 + " / " + N2);
            else
                MessageBox.Show("" + n2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
