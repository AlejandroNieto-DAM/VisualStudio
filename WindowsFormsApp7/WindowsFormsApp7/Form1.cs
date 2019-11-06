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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            palabraSecreta = "Hola";
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
         
            Boolean encontrada = false;
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
                    
                label6.Text = "Wnner!!";
                button1.Enabled = false;

            }
            
    
        }

        public String hacerPalabra(String palabra)
        {
            String palabra2 = "";
            foreach (Char l in palabra)
            {

                palabra2 += l + "_";


            }
            
            return palabra;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Char letra = Convert.ToChar(textBox1.Text);

            this.comprobarLetra(letra);

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
    }
}
