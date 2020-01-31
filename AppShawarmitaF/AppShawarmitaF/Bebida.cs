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

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            Comida b1 = new Comida();
            b1.setName("Agua");
            b1.setPrecio(1.5);
            b1.setImage(pictureBox1.Image);

            Form1.carrito.Add(b1);
            Carrito a = new Carrito();
            a.Visible = true;

            Form1.principal.Visible = false;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comida b2 = new Comida();
            b2.setName("Coca Cola");
            b2.setPrecio(1.8);
            b2.setImage(pictureBox2.Image);

            Form1.carrito.Add(b2);
            Carrito a = new Carrito();
            a.Visible = true;

            Form1.principal.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Comida b3 = new Comida();
            b3.setName("Fanta");
            b3.setPrecio(2);
            b3.setImage(pictureBox3.Image);

            Form1.carrito.Add(b3);
            Carrito a = new Carrito();
            a.Visible = true;

            Form1.principal.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comida b4 = new Comida();
            b4.setName("Aquarius");
            b4.setPrecio(1.7);
            b4.setImage(pictureBox4.Image);

            Form1.carrito.Add(b4);
            Carrito a = new Carrito();
            a.Visible = true;

            Form1.principal.Visible = false;
        }
    }
}
