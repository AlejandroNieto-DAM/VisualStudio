using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {

     
        ArrayList palabras;
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
            palabras = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventanaJuego = new Form1(palabras);
            ventanaJuego.Visible = true;
           
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            palabras.Add("hola");
            palabras.Add("pepe");
            palabras.Add("jarra");
            palabras.Add("willy");
            palabras.Add("raul");

       
            button1.Enabled = true;

            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            palabras.Add("camion");
            palabras.Add("teclado");
            palabras.Add("monitor");
            palabras.Add("portatil");
            palabras.Add("botella");


            button2.Enabled = false;
            button4.Enabled = false;

            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            palabras.Add("alguacil");
            palabras.Add("diazepam");
            palabras.Add("destornillador");
            palabras.Add("diclofenaco");
            palabras.Add("dietilamonico");


            button2.Enabled = false;
            button3.Enabled = false;

            button1.Enabled = true;
        }
    }
}
