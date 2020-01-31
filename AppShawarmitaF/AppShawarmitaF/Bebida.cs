using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppShawarmitaF
{
    public partial class Bebida : UserControl
    {
        public Bebida()
        {
            InitializeComponent();
        }

        private void buscarYPersonalizar(String nombre)
        {
            foreach (Comida comida in Form1.burguersTienda)
            {
                if (comida.getName().Equals(nombre))
                {
                    Comida aux = new Comida();
                    aux.setName(comida.getName());
                    aux.setPrecio(comida.getPrecio());



                    if (nombre.Equals("Agua"))
                    {
                        aux.setImage(pictureBox1.Image);
                    }
                    else if (nombre.Equals("Coca Cola"))
                    {
                        aux.setImage(pictureBox2.Image);
                    }
                    else if (nombre.Equals("Aquarius"))
                    {
                        aux.setImage(pictureBox3.Image);
                    }
                    else
                    {
                        aux.setImage(pictureBox4.Image);
                    }




                    Personalizacion a = new Personalizacion(aux);
                    a.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Agua");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Coca Cola");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Aquarius");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Fanta");

        }
    }
}
