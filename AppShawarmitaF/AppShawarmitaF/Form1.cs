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

namespace AppShawarmitaF
{
    public partial class Form1 : Form
    {
        public static ArrayList carrito;
        public static ArrayList burguersTienda;

        public Form1()
        {
            InitializeComponent();
            carrito = new ArrayList();
            burguersTienda = new ArrayList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            burguers2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            kebab1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Comida aux = new Comida();
            aux.setName("Burguer Demoniaca");
            aux.setPrecio(15);

            Comida aux1 = new Comida();
            aux1.setName("Burguer No Demoniaca");
            aux1.setPrecio(10);

            Comida aux2 = new Comida();
            aux2.setName("Burguer Normal");
            aux2.setPrecio(1);

            Comida aux3 = new Comida();
            aux3.setName("Burguer Celiaca");
            aux3.setPrecio(7);

            burguersTienda.Add(aux);
            burguersTienda.Add(aux1);
            burguersTienda.Add(aux2);
            burguersTienda.Add(aux3);

            Comida k1 = new Comida();
            k1.setName("Shawarma Demoniaco");
            k1.setPrecio(15);

            Comida k2 = new Comida();
            k2.setName("Shawarma No Demoniaco");
            k2.setPrecio(10);

            Comida k3 = new Comida();
            k3.setName("Shawarma Normal");
            k3.setPrecio(1);

            Comida k4 = new Comida();
            k4.setName("Shawarma Celiaco");
            k4.setPrecio(7);

            burguersTienda.Add(k1);
            burguersTienda.Add(k2);
            burguersTienda.Add(k3);
            burguersTienda.Add(k4);


            Comida b1 = new Comida();
            b1.setName("Agua");
            b1.setPrecio(1.5);

            Comida b2 = new Comida();
            b2.setName("Coca Cola");
            b2.setPrecio(1.8);

            Comida b3 = new Comida();
            b3.setName("Fanta");
            b3.setPrecio(2);

            Comida b4 = new Comida();
            b4.setName("Aquarius");
            b4.setPrecio(1.7);

            burguersTienda.Add(b1);
            burguersTienda.Add(b2);
            burguersTienda.Add(b3);
            burguersTienda.Add(b4);

            burguers2.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bebida1.BringToFront();
        }
    }
}
