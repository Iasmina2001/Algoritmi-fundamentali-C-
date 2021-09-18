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
    public partial class Form28 : Form
    {
        public int[] v = new int[100];
        public Form28()
        {
            InitializeComponent();
        }

        public int Sum(int ls, int ld)
        {
            int D = 0, mij = 0, S = 0;
            if (ls == ld)
            {
                return v[ls];
            }
            else
            {
                mij = (ls + ld) / 2;
                S = Sum(ls, mij);
                D = Sum(mij + 1, ld);
                return S + D;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            v = richTextBox1.Text.Split(' ').Select(s => Int32.Parse(s)).ToArray();
            int Suma = Sum(1, n);
            MessageBox.Show("" + Suma);
        }
    }
}
