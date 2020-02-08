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

            

            PersonalizacionOtros a = new PersonalizacionOtros(b1);
            a.Visible = true;
            Form1.principal.Visible = false;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comida b2 = new Comida();
            b2.setName("Coca Cola");
            b2.setPrecio(1.8);
            b2.setImage(pictureBox2.Image);

           
            PersonalizacionOtros a = new PersonalizacionOtros(b2);
            a.Visible = true;

            Form1.principal.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Comida b3 = new Comida();
            b3.setName("Aquarius");
            b3.setPrecio(2);
            b3.setImage(pictureBox3.Image);

            PersonalizacionOtros a = new PersonalizacionOtros(b3);
            a.Visible = true;

            Form1.principal.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comida b4 = new Comida();
            b4.setName("Fanta");
            b4.setPrecio(1.7);
            b4.setImage(pictureBox4.Image);

            PersonalizacionOtros a = new PersonalizacionOtros(b4);
            a.Visible = true;

            Form1.principal.Visible = false;
        }

        private void Bebida_Load(object sender, EventArgs e)
        {

        }
    }
}
