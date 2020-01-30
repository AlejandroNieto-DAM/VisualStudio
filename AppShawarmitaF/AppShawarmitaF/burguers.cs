using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppShawarmitaF
{
    public partial class burguers : UserControl
    {
        public burguers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            foreach (Comida comida in Form1.burguersTienda){
                if (comida.getName().Equals("Burguer Demoniaca"))
                {
                    Comida aux = new Comida();
                    aux.setName(comida.getName());
                    aux.setImage(pictureBox1.Image);
                    aux.setPrecio(comida.getPrecio());
                    Console.WriteLine("uiasdgfsdfgsdkajghjkfgadhjfk");
                    Personalizacion a = new Personalizacion(aux);
                    a.Visible = true;
                }
            }   

        }
    }
}
