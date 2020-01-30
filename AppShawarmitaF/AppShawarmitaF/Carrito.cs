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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();

        }

        private void Carrito_Load(object sender, EventArgs e)
        {

            Console.WriteLine("Antonio la chupa " + Form1.carrito.Count);

            foreach (Comida a in Form1.carrito)
            {
                listView1.Items.Add(a.getName());
            }
        }
    }
}
