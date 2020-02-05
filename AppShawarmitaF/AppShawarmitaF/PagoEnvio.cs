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
    public partial class PagoEnvio : Form
    {

        Random random = new Random();

        public static PagoEnvio myPagoEnvio;


        public static String ticket;

        public PagoEnvio()
        {
            InitializeComponent();
            myPagoEnvio = this;
            mensajeError1.Visible = false;
            mensajeError1.SendToBack();
            mensajeConfirmar1.Visible = false;
            mensajeConfirmar1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = (Color.Gold);
            button2.BackColor = Color.LimeGreen;
            label1.Text = "Dirección";
            label2.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            button2.BackColor = (Color.Gold);
            button1.BackColor = Color.LimeGreen;
            label1.Text = "Nº Mesa";
            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = (Color.Gold);
            button4.BackColor = Color.LimeGreen;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = (Color.Gold);
            button3.BackColor = Color.LimeGreen;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

        }

        private void PagoEnvio_Load(object sender, EventArgs e)
        {
            int randomNumber = random.Next(20, 60);
            button2.BackColor = (Color.Gold);
            button3.BackColor = (Color.Gold);
            label1.Text = "Nº Mesa";
            label1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;

            label6.Text = label6.Text + " " + randomNumber + " min";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            ticket = " PEDIDO " + "\n\n";
            Double totalPrecio = 0;
            foreach (Comida a in Form1.carrito)
            {

                String cebolla = "";
                String tomate = "";
                String lechuga = "";


                if (a.getCebolla() == true)
                {
                    cebolla = "\n\t + Cebolla";
                }

                if (a.getLechuga() == true)
                {
                    lechuga = "\n\t + Lechuga";
                }

                if (a.getTomate() == true)
                {
                    tomate = "\n\t + Tomate";
                }

                ticket = ticket + a.getName() + lechuga + tomate + cebolla + "\n";

                totalPrecio += a.getPrecio();
                
            }

            ticket += "\n\t\t PRECIO A PAGAR --> " + Carrito.totalPrecio +  "€";
            ticket += "\n " + label6.Text + " minutos";
            

            if(button3.BackColor == (Color.Gold))
            {
                ticket += "\n\n Debera pasar por caja para pagarlo.";
            }
            else if(button3.BackColor == (Color.Gold))
            {
                ticket += "\n\n La transaccion ha sido correcta.";
            }

            Boolean todoCorrecto = true;

            if (button2.BackColor == (Color.Gold))
            {
                if (textBox1.Text == "")
                {
                    todoCorrecto = false;
                }
            }
            else if (button2.BackColor == (Color.Gold))
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    todoCorrecto = false;
                }
            }

            if (button4.BackColor == (Color.Gold))
            {
                if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    todoCorrecto = false;
                }
            }


            if (todoCorrecto)
            {
                mensajeConfirmar1.Visible = true;
                mensajeConfirmar1.BringToFront();
            }
            else
            {
                mensajeError1.Visible = true;
                mensajeError1.BringToFront();
            }


        }

        private void mensajeConfirmar1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Carrito a = new Carrito();
            a.Visible = true;
            this.Close();
        }
    }
}
