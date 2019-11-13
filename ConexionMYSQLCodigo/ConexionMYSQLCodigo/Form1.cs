using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ConexionMYSQLCodigo
{
    public partial class Form1 : Form
    {

        static MySqlConnection Conex = new MySqlConnection();
        static string serv = "Server=localhost;";
        static string db = "Database=desarrollointf;";
        static string usuario = "UID=root;";
        static string pwd = "";
        string cadenaDeConexion = serv + db + usuario + pwd;

        int idContactos = 0;

        public void conectar()
        {
            try
            {
                Conex.ConnectionString = cadenaDeConexion;
                Conex.Open();
                MessageBox.Show("LA BD ESTA CONECTADA");
            }
            catch(Exception)
            {
                MessageBox.Show("AAASSSSTIAS QUE NO PUEDO CONECTAR");
                throw;
            }
        }

        public void desconectar()
        {
            Conex.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conectar();
            dataGridViewLoad();
            comboBoxLoad();
            iniciarID();
             
        }

        private void iniciarID()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = Conex.CreateCommand();
            cmd.CommandText = "SELECT id_contacto FROM CONTACTOS;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

        

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    if(Int32.Parse(row[col].ToString()) > idContactos)
                    {
                        idContactos = Int32.Parse(row[col].ToString());
                    }
                }
            }
        }

        private void dataGridViewLoad()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = Conex.CreateCommand();
            cmd.CommandText = "SELECT * FROM CONTACTOS;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBoxLoad()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = Conex.CreateCommand();
            cmd.CommandText = "SELECT cp FROM CONTACTOS;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            comboBox1.Items.Add("ALL");

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    comboBox1.Items.Add(row[col]);
                }
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object cp = comboBox1.SelectedItem;

            DataTable dtt = new DataTable();
            MySqlCommand cmd = Conex.CreateCommand();

            if (cp.ToString().Equals("ALL"))
            {
                cmd.CommandText = "SELECT * FROM CONTACTOS;";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM CONTACTOS WHERE cp = \"" + cp.ToString() + "\" ;";
            }
            
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtt);
            dataGridView1.DataSource = dtt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idContactos++;
            MySqlCommand cmd = Conex.CreateCommand();
            cmd.CommandText = "INSERT INTO contactos VALUES ('" + idContactos + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox6.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "');";
            cmd.ExecuteNonQuery();
            comboBox1.Items.Add(textBox4.Text);
            dataGridViewLoad();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
