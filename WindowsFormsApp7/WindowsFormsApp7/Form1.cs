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
                label5.Text += "_";
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
                        label6.Text = "La letra esta en la palabra!";
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
                    }
                }
            }
            
            
        }

        public void tratarLetra(Char letra)
        {
            String palabraActualizada = label5.Text;
            String palabraAct = "";
         
            Boolean encontrada = false;

            foreach (Char l in palabraActualizada)
            {
                if (l.Equals('_'))
                {
                    
                    foreach (Char l2 in palabraSecreta)
                    {
                        if (l2.Equals(letra))
                        {
                            palabraAct += l2;
                        }
                        else
                        {
                            palabraAct += "_";
                        }
                    }
                }
                else
                {
                    palabraAct += l;
                }
            }

            label5.Text = "";
            label5.Text = palabraAct;
            

          //  label5.Text = this.hacerPalabra(palabraActualizada);

            if (palabraActualizada.Equals(palabraSecreta))
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
    }
}
