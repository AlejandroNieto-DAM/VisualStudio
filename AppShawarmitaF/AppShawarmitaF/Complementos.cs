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

            PersonalizacionOtros a = new PersonalizacionOtros(nuggets);
            a.Visible = true;
            Form1.principal.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comida patatasf = new Comida();
            patatasf.setImage(pictureBox2.Image);
            patatasf.setName("Patatas fritas");
            patatasf.setPrecio(3);

            PersonalizacionOtros a = new PersonalizacionOtros(patatasf);
            a.Visible = true;
            Form1.principal.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Comida alitas = new Comida();
            alitas.setImage(pictureBox3.Image);
            alitas.setName("Alitas");
            alitas.setPrecio(5);

            PersonalizacionOtros a = new PersonalizacionOtros(alitas);
            a.Visible = true;
            Form1.principal.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comida patatasd = new Comida();
            patatasd.setImage(pictureBox3.Image);
            patatasd.setName("Patatas Deluxe");
            patatasd.setPrecio(4);

            PersonalizacionOtros a = new PersonalizacionOtros(patatasd);
            a.Visible = true;
            Form1.principal.Visible = false;
        }

        private void Complementos_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
