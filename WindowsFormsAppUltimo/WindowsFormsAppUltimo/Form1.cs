using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUltimo
{
    public partial class Form1 : Form
    {
        private double fantaNaranja = 1.95;
        private double cocacola = 2.50;
        private double fantaLimon = 1.70;
        private double nestea = 2.90;
        private double agua = 3.00;

        private double dineroInsertado = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selected = textBox6.Text;



            if((Int32.Parse(selected) > 0 && Int32.Parse(selected) <= 5) && selected != "")
            {
                switch (selected)
                {
                    case "1": label2.Text = "Precio = " + cocacola.ToString() + "€"; break;
                    case "2": label2.Text = "Precio = " + nestea.ToString() + "€"; break;
                    case "3": label2.Text = "Precio = " + fantaNaranja.ToString() + "€"; break;
                    case "4": label2.Text = "Precio = " + fantaLimon.ToString() + "€"; break;
                    case "5": label2.Text = "Precio = " + agua.ToString() + "€"; break;
                }
            }
            else
            {
                label2.Text = "Numero mal introducido!";
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dineroInsertado += 0.50;
            textBox7.Text = dineroInsertado.ToString() + "€";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dineroInsertado += 0.20;
            textBox7.Text = dineroInsertado.ToString() + "€";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dineroInsertado += 1.0;
            textBox7.Text = dineroInsertado.ToString() + "€";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String selected = textBox6.Text;

            Console.WriteLine("eyeye");

            double devolucion = 0.0;


            if ((Int32.Parse(selected) > 0 && Int32.Parse(selected) <= 5) && selected != "")
            {


                switch (selected)
                {
                    case "1": devolucion = dineroInsertado - cocacola; break;
                    case "2": devolucion = dineroInsertado - nestea; break;
                    case "3": devolucion = dineroInsertado - fantaNaranja; break;
                    case "4": devolucion = dineroInsertado - fantaLimon; break;
                    case "5": devolucion = dineroInsertado - agua; break;
                }

                label4.Text = "Devolucion = " + devolucion.ToString() + " Gracias por su compra!";

            }
            else
            {
                label2.Text = "Numero mal introducido!";
            }






            dineroInsertado = 0.0;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
