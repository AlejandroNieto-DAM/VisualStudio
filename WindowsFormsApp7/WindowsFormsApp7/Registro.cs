using System;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Persona a = new Persona(textBox1.Text, textBox2.Text);

            Form2 ventanaJuego = new Form2();
            Form2.personas.Add(a);
            this.Visible = false;
            ventanaJuego.Visible = true;
        }
    }
}
