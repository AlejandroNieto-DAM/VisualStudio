using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace AppShawarmitaF
{
    public partial class Carrito : Form
    {

        public static Double totalPrecio;
        ArrayList seMuestra;
        Boolean codigoUsado1 = false;

        private String codigoDescuento = "Demonio";
        private String codigoDescuento2 = "losespetoslomejor34";

        public Carrito()
        {
            InitializeComponent();
            totalPrecio = 0.0;
            seMuestra = new ArrayList();

        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Carrito", 400);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            populate();

            if(totalPrecio > 40 && totalPrecio < 50)
            {
                totalPrecio = totalPrecio * Form1.promocion1;
                label5.Text = "Promocion de descuento del 20%";
                label5.Visible = true;

            }
            else if (totalPrecio >= 50)
            {

                totalPrecio = totalPrecio * Form1.promocion2;
                label5.Text = "Promocion de descuento del 30%";
                label5.Visible = true;
            }


            

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

            int contador = 0;

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

                if (a.getGrande() == true)
                {
                    cebolla = "\n\t + Grande";
                }

                if (a.getPequenio() == true)
                {
                    lechuga = "\n\t + Pequeño";
                }

                if (a.getMediano() == true)
                {
                    tomate = "\n\t + Mediano";
                }

                listView1.Items.Add(a.getName() + lechuga + tomate + cebolla, contador);

                totalPrecio += a.getPrecio();
                contador++;
            }

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Form1.carrito.Add(listView1.GetItemAt(0,0));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Numero total de cosas en el array --> " + Form1.carrito.Count);
            if (Form1.carrito.Count != 0)
            {
                PagoEnvio a = new PagoEnvio();
                a.Visible = true;
                this.Close();
            }
            else
            {
                label9.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int indiceABorrar = listView1.SelectedIndices[0];
                listView1.Items.RemoveAt(indiceABorrar);
                Form1.carrito.RemoveAt(indiceABorrar);
                Carrito a = new Carrito();
                a.Visible = true;
                this.Close();

            }
            catch (ArgumentOutOfRangeException ex)
            {
                label3.Text = "Debes seleccionar un producto para eliminarlo.";
                label3.Visible = true;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text.Equals(codigoDescuento) && totalPrecio > 15 && codigoUsado1 == false)
                {
                    totalPrecio = totalPrecio - 5;
                    label6.Text = "Codigo descuento aceptado!";
                    label6.Visible = true;
                    label2.Text = totalPrecio.ToString() + "€";

                    codigoUsado1 = true;
                }
                else if (textBox1.Text.Equals(codigoDescuento2))
                {
                    totalPrecio = totalPrecio - 100;
                    label6.Text = "Codigo descuento aceptado!";
                    label6.Visible = true;
                    label2.Text = totalPrecio.ToString() + "€";
                }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1.principal.Visible = true;
            this.Close();

        }
    }
}
