using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String passwd = textBox2.Text;

            foreach(Persona a in Form2.personas)
            {
                if (login.Equals(a.getLogin()) && passwd.Equals(a.getPasswd()))
                {
                    AñadirPalabra ventanaAniadir = new AñadirPalabra();
                    ventanaAniadir.Visible = true;
                    this.Visible = false;  
                }
            }
        }
    }
}
