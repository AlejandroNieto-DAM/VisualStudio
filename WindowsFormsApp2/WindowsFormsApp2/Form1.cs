using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        String a;
        String b;
        int numero1;
        int numero2;

        public Form1()
        {

            InitializeComponent();
            a = "";
            b = "";
            numero1 = 0;
            numero2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            numero1 = Int32.Parse(a);
            b = textBox2.Text;
            numero2 = Int32.Parse(b);
            String resultado = (numero1 + numero2).ToString();
            textBox3.Text = resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Numero entero";
            textBox2.Text = "Numero entero 2";
            textBox3.Text = "Resultado";
        }
    }
}
