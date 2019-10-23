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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            CuentaBancaria cuenta1 = new CuentaBancaria();
            cuenta1.setNombreCuenta("Cuenta Normal");
            cuenta1.setNumCuenta(123456789);
            cuenta1.setSaldoCuenta(10000);
            cuenta1.setTipoInteres(4);

            textBox1.Text = cuenta1.getNombreCuenta();
            textBox2.Text = cuenta1.getNumCuenta().ToString();
            textBox3.Text = cuenta1.getSaldoCuenta().ToString();
            textBox4.Text = cuenta1.getTipoInteres().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventanPrincipal = new Form1();
            this.Visible = false;
            ventanPrincipal.Visible = true;

        }
    }
}
