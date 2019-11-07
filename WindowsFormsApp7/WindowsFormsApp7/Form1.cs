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

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        private String palabraSecreta = "";
        private int intentos = 5;
        ArrayList letrasUsadas = new ArrayList();
        ArrayList palabras;

        public Form1(ArrayList palabras)
        {
            InitializeComponent();
            this.palabras = palabras;
            button2.Visible = false;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(palabras.Count - 1);

            int contador = 0;
            foreach(String i in palabras){
                if(contador == numeroAleatorio)
                {
                    palabraSecreta = i;
                }

                contador++;
            }

            for (int i = 0; i < palabraSecreta.Length - 1; i++)
            {
                label5.Text += "_ ";
            }
            label5.Text += "_";
        }

        public void comprobarLetra(Char letra)
        {

            Boolean encontrado = false;
            Boolean encontradoRepe = false;

            foreach (Char l in letrasUsadas)
            {
                if (l.Equals(letra))
                {
                    encontradoRepe = true;
                }
            }

            letrasUsadas.Add(letra);

            if(encontradoRepe == false)
            {
                foreach (Char l in palabraSecreta)
                {
                    if (l.Equals(letra))
                    {
                        encontrado = true;
                        
                    }
                }

                if (encontrado == true)
                {
                    this.tratarLetra(letra);
                }
                else
                {
                    
                    label3.Text += letra + " ";
                    intentos--;
                    if (intentos == 0)
                    {
                        label6.Text = "Game over!";
                        button1.Enabled = false;
                        pictureBox6.Visible = true;
                        button2.Visible = true;
                        button2.Enabled = true;
                        label5.Text = "";
                        for (int i = 0; i < palabraSecreta.Length - 1; i++)
                        {
                            label5.Text += palabraSecreta[i];
                        }
                        label5.Text += palabraSecreta[palabraSecreta.Length - 1];
                    }
                    else if (intentos == 4)
                    {
                        pictureBox1.Visible = true;
                    }
                    else if (intentos == 3)
                    {
                        pictureBox2.Visible = true;
                    }
                    else if (intentos == 2)
                    {
                        pictureBox3.Visible = true;
                    }
                    else if (intentos == 1)
                    {
                        pictureBox4.Visible = true;
                    }
                }
            }
            
            
        }

        public void tratarLetra(Char letra)
        {
            String palabraActualizada = label5.Text.Replace(" ", "");
            String palabraAct = "";
         
            
            int contador = 0;
            foreach (Char l in palabraActualizada)
            {
                if (!l.Equals('_'))
                {
                    palabraAct += l;
                }
                else if(letra.Equals(palabraSecreta[contador]))
                {

                    palabraAct += letra;
                    
                }
                else
                {
                    palabraAct += "_";
                }

                contador++;
            }

            label5.Text = "";
            
            for(int i = 0; i < palabraActualizada.Length - 1; i++)
            {
                label5.Text += palabraAct[i] + " ";
            }

            label5.Text += palabraAct[palabraAct.Length - 1].ToString();



            if (palabraAct.Equals(palabraSecreta))
            {
                    
                label6.Text = "Winner!!";
                button1.Enabled = false;
                button2.Visible = true;
                button2.Enabled = true;

            }
            
    
        }


        private void button1_Click(object sender, EventArgs e)
        {

            String l = textBox1.Text;
            

            if(l.Length == 1)
            {
               
                Char letra = Convert.ToChar(l);

                this.comprobarLetra(letra);
            }
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList palabras = Form2.palabras;
            ArrayList personas = Form2.personas;

            Form2 ventanaInicial = new Form2();
            Form2.palabras = palabras;
            Form2.personas = personas;
            this.Visible = false;
            ventanaInicial.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
