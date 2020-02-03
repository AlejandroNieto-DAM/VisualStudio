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
    public partial class MensajeConfirmar : UserControl
    {
        public MensajeConfirmar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoEnvio.myPagoEnvio.Visible = false;

            Ticket b = new Ticket(PagoEnvio.ticket);
            b.Visible = true;
            this.Visible = false;

             

            Form1.principal.Visible = true;
            Form1.carrito.Clear();



        }
    }
}
