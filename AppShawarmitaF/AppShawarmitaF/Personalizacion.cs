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
    public partial class Personalizacion : Form
    {

        String nombrePrecio;

        public Personalizacion(Image a, String nombre_precio)
        {
            InitializeComponent();
            pictureBox1.Image = a;
            this.nombrePrecio = nombre_precio;
            label1.Text = nombre_precio.Substring(0, nombre_precio.IndexOf(","));
        }

      

        private void Personalizacion_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carrito a = new Carrito();
            a.Visible = true;
            Form1.carrito.Add(nombrePrecio);
            this.Close();
        }
    }
}
