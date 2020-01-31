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
    public partial class burguers : UserControl
    {
        Form form;

        public burguers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            buscarYPersonalizar("Burguer Demoniaca");
        }

        private void burguers_Load(object sender, EventArgs e)
        {
            
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



                    if (nombre.Equals("Burguer Demoniaca"))
                    {
                        aux.setImage(pictureBox1.Image);
                    }
                    else if (nombre.Equals("Burguer No Demoniaca"))
                    {
                        aux.setImage(pictureBox2.Image);
                    }
                    else if (nombre.Equals("Burguer Normal"))
                    {
                        aux.setImage(pictureBox3.Image);
                    }
                    else
                    {
                        aux.setImage(pictureBox4.Image);
                    }


                    
                    Personalizacion a = new Personalizacion(aux);
                    a.Visible = true;
                    Form1.principal.Visible = false;

                }

                
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Burguer No Demoniaca");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscarYPersonalizar("Burguer Normal");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            buscarYPersonalizar("Burguer Celiaca");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
