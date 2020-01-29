using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppShawarmita
{
    public partial class Form1 : Form
    {
        Boolean state_hamburguer = true;
        Boolean state_kebab = false;
        Boolean state_bebida = false;
        Boolean state_complementos = false;

        userControl11.ButtonClick += new EventHandler(UserControl_ButtonClick);


        public Form1()
        {
            InitializeComponent();
           
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            state_hamburguer = true;
            
            state_bebida = false;
            state_kebab = false;
            state_complementos = false;


            if (userControl11.popular == true)
            {
                Console.WriteLine("Sa io pa eeeearaa");

            }

            if (userControl11.todos == true)
            {
                Console.WriteLine("Sa io pa tra");

            }


            




        }

        public void UserControl_ButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("Dimonio");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            state_kebab = true;

            state_hamburguer = false;
            state_bebida = false;
            state_complementos = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();

            state_bebida = true;

            state_kebab = false;
            state_complementos = false;
            state_hamburguer = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
            state_complementos = true;

            state_bebida = false;
            state_kebab = false;
            state_hamburguer = false;
        }
    }
}
