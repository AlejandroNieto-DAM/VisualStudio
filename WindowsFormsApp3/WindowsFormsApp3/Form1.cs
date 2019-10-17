using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String password = textBox2.Text;

            if(login.Equals("@nieto_off")  && password.Equals("nietillomaquinilla1"))
            {
                MessageBox.Show("Bienvenido muxaxo");
            }
            else if (!login.Equals("@nieto_off") || !password.Equals("nietillomaquinilla1"))
            {
                MessageBox.Show("Tas equivocao en argo");
            }
            else
            {
                MessageBox.Show("Que has hecho hombre :( Error fatal!");
            }
        }
    }
}
