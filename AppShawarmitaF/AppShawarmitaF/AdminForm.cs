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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            double pro1 = (1 - Form1.promocion1) * 100;
            double pro2 = (1 - Form1.promocion2) * 100;


            textBox1.Text = pro1.ToString();
            textBox2.Text = pro2.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && Double.Parse(textBox1.Text) < 50 && Double.Parse(textBox2.Text) < 50)
            {
                Form1.promocion1 = Double.Parse(textBox1.Text);
                Form1.promocion2 = Double.Parse(textBox2.Text);
                this.Visible = false;
                Form1.principal.Visible = true;
            }
        }
    }
}
