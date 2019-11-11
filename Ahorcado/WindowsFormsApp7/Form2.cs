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
    public partial class Form2 : Form
    {
        public static ArrayList personas;
     
        public static ArrayList palabras;
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
            palabras = new ArrayList();
            personas = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventanaJuego = new Form1(palabras);
            ventanaJuego.Visible = true;
           
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            palabras.Add("alguacil");
            palabras.Add("diazepam");
            palabras.Add("destornillador");
            palabras.Add("diclofenaco");
            palabras.Add("dietilamonico");
            palabras.Add("exhumacion");
            palabras.Add("aletargadamente");


            button1.Enabled = true;

            button2.BackColor = Color.Green;
            button3.BackColor = button1.BackColor;
            button4.BackColor = button1.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            palabras.Add("camion");

            palabras.Add("teclado");
            palabras.Add("monitor");
            palabras.Add("portatil");
            palabras.Add("botella");
            palabras.Add("programar");
            palabras.Add("rotulador");


            button3.BackColor = Color.Green;
            button2.BackColor = button1.BackColor;
            button4.BackColor = button1.BackColor;
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            palabras.Add("hola");
            palabras.Add("pepe");
            palabras.Add("jarra");
            palabras.Add("willy");
            palabras.Add("ñu");
            palabras.Add("te");


            button4.BackColor = Color.Green;
            button3.BackColor = button1.BackColor;
            button2.BackColor = button1.BackColor;

            button1.Enabled = true;
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login ventanaLogin = new Login();
            ventanaLogin.Visible = true;
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            personas.Add(new Persona("admin", "admin"));
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro ventanaRegistro = new Registro();
            this.Visible = false;
            ventanaRegistro.Visible = true;
        }
    }
}
