using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionMYSQLOrigenesDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cocheBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cocheBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cocheDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cocheDataSet.coche' Puede moverla o quitarla según sea necesario.
            this.cocheTableAdapter.Fill(this.cocheDataSet.coche);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 estoEsMiForm = new Form1();
            Object estoEsMiReport = new CachedCrystalReport2();
            System.Data.Odbc.OdbcDataAdapter adaptador = new System.Data.Odbc.OdbcDataAdapter("SELECT * FROM coches", );
            DataSet dt = new DataSet();
            adaptador.Fill(dt);
            estoEsMiForm.Show();
              
        }
    }
}
