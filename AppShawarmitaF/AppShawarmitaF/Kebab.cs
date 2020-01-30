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
    public partial class Kebab : UserControl
    {
        public Kebab()
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



                    if (nombre.Equals("Shawarma Demoniaco"))
                    {
                        aux.setImage(pictureBox1.Image);
                    }
                    else if (nombre.Equals("Shawarma No Demoniaco"))
                    {
                        aux.setImage(pictureBox2.Image);
                    }
                    else if (nombre.Equals("Shawarma Normal"))
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
            buscarYPersonalizar("Shawarma Demoniaco");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Shawarma No Demoniaco");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Shawarma Normal");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Shawarma Celiaco");
        }
    }
}
