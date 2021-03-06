﻿using System;
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
        int cantidad = 1;
        Random random = new Random();
        Boolean aniadido = false;
        public Personalizacion(Comida comidaSeleccionada)
        {
            InitializeComponent();

            pictureBox1.Image = comidaSeleccionada.getImage();
             
            seleccionada.setName(comidaSeleccionada.getName());
            seleccionada.setPrecio(comidaSeleccionada.getPrecio());
            seleccionada.setImage(comidaSeleccionada.getImage());
            textBox1.Text = cantidad.ToString();

        }



        private void Personalizacion_Load(object sender, EventArgs e)
        {
            int randomNumber = random.Next(0, 100);
            if(randomNumber >= 50)
            {
                pictureBox4.Visible = true;
            }

            label1.Text = seleccionada.getName();
            label5.Text = seleccionada.getPrecio() + "€";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (aniadido == false) { 

                for(int i = 0; i < Int16.Parse(textBox1.Text); i++)
                {
                    Form1.carrito.Add(seleccionada);
                }
            
                Carrito a = new Carrito();
                a.Visible = true;
                this.Close();
            }
  
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.principal.Visible = true;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(cantidad > 1)
            {
                cantidad--;
                textBox1.Text = cantidad.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            cantidad++;
            textBox1.Text = cantidad.ToString();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            if (aniadido == false)
            {

                for (int i = 0; i < Int16.Parse(textBox1.Text); i++)
                {
                    Form1.carrito.Add(seleccionada);
                }

                Form1.principal.Visible = true;
                this.Close();

                aniadido = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Carrito a = new Carrito();
            a.Visible = true;
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
