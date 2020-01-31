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
    public partial class Complementos : UserControl
    {
        public Complementos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comida nuggets = new Comida();
            nuggets.setImage(pictureBox1.Image);
            nuggets.setName("Nuggets Demoniacos");
            nuggets.setPrecio(5);

            Form1.carrito.Add(nuggets);
            Carrito a = new Carrito();
            a.Visible = true;
            Form1.principal.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comida patatasf = new Comida();
            patatasf.setImage(pictureBox2.Image);
            patatasf.setName("Patatas fritas");
            patatasf.setPrecio(3);

            Form1.carrito.Add(patatasf);
            Form1.principal.Visible = false;
            Carrito a = new Carrito();
            a.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Comida alitas = new Comida();
            alitas.setImage(pictureBox3.Image);
            alitas.setName("Alitas");
            alitas.setPrecio(5);

            Form1.carrito.Add(alitas);
            Carrito a = new Carrito();
            a.Visible = true;
            Form1.principal.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comida patatasd = new Comida();
            patatasd.setImage(pictureBox3.Image);
            patatasd.setName("Patatas Deluxe");
            patatasd.setPrecio(4);

            Form1.carrito.Add(patatasd);
            Carrito a = new Carrito();
            a.Visible = true;
            Form1.principal.Visible = false;
        }
    }
}
