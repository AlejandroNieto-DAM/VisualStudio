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
    public partial class HPopular : UserControl
    {
        public HPopular()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void HPopular_Load(object sender, EventArgs e)
        {

        }

        public void setChecked()
        {
            checkBox1.Checked = true;
        }
    }
}
