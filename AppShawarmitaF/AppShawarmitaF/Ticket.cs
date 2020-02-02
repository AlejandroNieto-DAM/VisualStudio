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
    public partial class Ticket : Form
    {
        public Ticket(String ticket)
        {
            InitializeComponent();
            label1.Text = ticket;
        }
    }
}
