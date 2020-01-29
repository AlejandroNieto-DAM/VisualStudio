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
            Personalizacion a = new Personalizacion(pictureBox1.Image);
            this.Dispose(false);
            a.Visible = true;
        }
    }
}
