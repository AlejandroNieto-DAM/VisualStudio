using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(domainUpDown1.Text);
            int suma = 0; 
            
            for(int i = 1; i <= a; i++)
            {
                
                if (checkBox1.Checked)
                {
                    textBox1.Text += "sumando: " +  i.ToString() + " Suma parcial: " + suma.ToString() + Environment.NewLine;
                }
                suma += i;
            }

            textBox1.Text += "\nEl resultado final es " + suma.ToString();
        }
    }
}
