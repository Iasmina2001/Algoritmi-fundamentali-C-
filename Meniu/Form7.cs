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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            richTextBox1.Text = richTextBox1.Text + "Pentru n = " + n + '\n';
            int uc = 0;
            while (n != 0)
            {
                uc = n % 10;
                n /= 10;
                richTextBox1.Text = richTextBox1.Text + uc + " ";
            }
            richTextBox1.Text = richTextBox1.Text + '\n';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
