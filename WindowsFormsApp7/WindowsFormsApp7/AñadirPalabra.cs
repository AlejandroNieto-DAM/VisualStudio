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
    public partial class AñadirPalabra : Form
    {
        public AñadirPalabra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String palabra = textBox1.Text;
            ArrayList personas = Form2.personas;
            ArrayList palabras = Form2.palabras;
            Form2 ventanaInicio = new Form2();
            Form2.palabras = palabras;
            Form2.personas = personas;
            Form2.palabras.Add(palabra);
            this.Visible = false;
            ventanaInicio.Visible = true;
        }
    }
}
