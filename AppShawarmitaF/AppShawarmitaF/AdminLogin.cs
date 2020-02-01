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
    public partial class AdminLogin : Form
    {

        public String loginAdmin = "Admin";
        public String passAdmin = "Admin";

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(loginAdmin) && textBox2.Text.Equals(passAdmin))
            {
                AdminForm a = new AdminForm();
                a.Visible = true;
                this.Close();
            }
            else
            {
                label3.Text = "Error de usuario o contraseña.";
                label3.Visible = true;
            }
        }
    }
}
