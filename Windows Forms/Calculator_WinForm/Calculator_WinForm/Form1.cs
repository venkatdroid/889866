using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(textBox1.Text);
            var b = Convert.ToDouble(textBox2.Text);
            double count = 0;
            if (rb2.Checked) {
                count = (a + b);
                MessageBox.Show(a+" + "+b +" = "+ count.ToString(),"Result");

            }
            else if (rb3.Checked)
            {
                count = (a - b);
                MessageBox.Show(a + " - " + b + " = " + count.ToString(), "Result");
            }
            else if (rb4.Checked)
            {
                count = (a * b);
                MessageBox.Show(a + " * " + b + " = " + count.ToString(), "Result");
            }
            else if (rb5.Checked)
            {
                count = (a / b);
                MessageBox.Show(a + " / " + b + " = " + count.ToString(), "Result");
            }
        }
    }
}
