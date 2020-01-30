using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppShawarmitaF
{
    public partial class Personalizacion : Form
    {

        Comida seleccionada = new Comida();

        public Personalizacion(Comida comidaSeleccionada)
        {
            InitializeComponent();

            pictureBox1.Image = comidaSeleccionada.getImage();
             
            seleccionada.setName(comidaSeleccionada.getName());
            seleccionada.setPrecio(comidaSeleccionada.getPrecio());
            seleccionada.setImage(comidaSeleccionada.getImage());
        }

      

        private void Personalizacion_Load(object sender, EventArgs e)
        {
            label1.Text = seleccionada.getName();
            label5.Text = seleccionada.getPrecio() + "€";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1.carrito.Add(seleccionada);
            Carrito a = new Carrito();
            a.Visible = true;
            this.Close();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(seleccionada.getTomate() == false)
            {
                seleccionada.setTomate(true);
            }
            else
            {
                seleccionada.setTomate(false);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
            if (seleccionada.getCebolla() == false)
            {
                seleccionada.setCebolla(true);
            }
            else
            {
                seleccionada.setCebolla(false);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (seleccionada.getLechuga() == false)
            {
                seleccionada.setLechuga(true);
            }
            else
            {
                seleccionada.setLechuga(false);
            }
        }
    }
}
