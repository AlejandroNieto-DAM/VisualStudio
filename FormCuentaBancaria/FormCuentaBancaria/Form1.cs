using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCuentaBancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventanaCuentaNormal = new Form2();
            this.Visible = false;
            ventanaCuentaNormal.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ventanaCuentaAhorro = new Form3();
            this.Visible = false;
            ventanaCuentaAhorro.Visible = true;
        }
    }
}
