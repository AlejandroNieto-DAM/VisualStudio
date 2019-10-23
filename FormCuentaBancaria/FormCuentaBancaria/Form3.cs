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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            CuentaAhorro cuenta2 = new CuentaAhorro();
            cuenta2.setNombreCuenta("Cuenta Ahorro");
            cuenta2.setNumCuenta(555555555);
            cuenta2.setSaldoCuenta(1000);
            cuenta2.setTipoInteres(2);
            cuenta2.setCuotaMantenimiento(100);

            textBox1.Text = cuenta2.getNombreCuenta();
            textBox2.Text = cuenta2.getNumCuenta().ToString();
            textBox3.Text = cuenta2.getSaldoCuenta().ToString();
            textBox4.Text = cuenta2.getTipoInteres().ToString();
            textBox5.Text = cuenta2.getCuotaMantenimiento().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventanPrincipal = new Form1();
            this.Visible = false;
            ventanPrincipal.Visible = true;
        }
    }
}
