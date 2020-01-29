using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppShawarmita
{
    public partial class UserControl1 : UserControl
    {
        public Boolean popular = false;
        public Boolean todos = false;
        public event EventHandler ButtonClick;

        public UserControl1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            popular = true;
            todos = false;

            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            todos = true;
            popular = false;
        }
    }
}
