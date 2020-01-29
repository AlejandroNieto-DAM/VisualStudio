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

namespace AppShawarmitaF
{
    public partial class Form1 : Form
    {
        public static ArrayList carrito;
        public static ArrayList burguersTienda;
        public Form1()
        {
            InitializeComponent();
            carrito = new ArrayList();
            burguersTienda = new ArrayList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            burguers2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            kebab1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            burguersTienda.Add("BurguerDemoniaca,10");
            burguersTienda.Add("BurguerNormal,5");
        }
    }
}
