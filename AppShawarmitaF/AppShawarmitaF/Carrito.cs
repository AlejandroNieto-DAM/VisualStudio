using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace AppShawarmitaF
{
    public partial class Carrito : Form
    {

        Double totalPrecio;
        ArrayList seMuestra;

        public Carrito()
        {
            InitializeComponent();
            totalPrecio = 0.0;
            seMuestra = new ArrayList();
            seMuestra.Add(Form1.carrito[0]);

        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Carrito", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            populate();

            label2.Text = totalPrecio + "€";

        }


        private void populate()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            foreach (Comida a in Form1.carrito)
            {
                imgs.Images.Add(a.getImage());
            }

            listView1.SmallImageList = imgs;



            foreach (Comida a in Form1.carrito)
            {

                String cebolla = "";
                String tomate = "";
                String lechuga = "";

                Console.WriteLine("yeyeo en mi iopgene " + a.getCebolla());

                if (a.getCebolla() == true)
                {
                    cebolla = "\n\t + Cebolla";
                }

                if (a.getLechuga() == true)
                {
                    lechuga = "\n\t + Lechuga";
                }

                if (a.getTomate() == true)
                {
                    tomate = "\n\t + Tomate";
                }

                listView1.Items.Add(a.getName() + lechuga + tomate + cebolla, 0);

                totalPrecio += a.getPrecio();

            }



        }

    


        

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Form1.carrito.Add(listView1.GetItemAt(0,0));
        }
    }
}
