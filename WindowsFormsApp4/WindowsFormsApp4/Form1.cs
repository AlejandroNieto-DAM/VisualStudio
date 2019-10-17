using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int costes = 0;

            if (radioButton1.Checked)
            {
                costes = 4;
            }
            else if(radioButton2.Checked)
            {
                costes = 6;
            }
            else if (radioButton3.Checked)
            {
                costes = 8;
            }

            costes = costes + Int32.Parse(textBox1.Text);
            label1.Text = costes.ToString() + "€";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
