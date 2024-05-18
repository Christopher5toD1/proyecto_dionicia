using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto_dionicia
{
    public partial class FormCliente : Form

    {

        public FormCliente()
        {
            string Rutaconexion = null;
            SqlConnection Conexion;
            string consulta = null;
            InitializeComponent();

            Rutaconexion = @"Data Source=CHRISTOPHERTOD1;Initial Catalog=ventas;Persist Security Info=True;User ID=sa;Password=1234; ";
            Conexion = new SqlConnection(Rutaconexion);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            SqlConnection conexion = new SqlConnection("server =CHRISTOPHERTOD1 ;database= ventas ; integrated security = true");
            conexion.Open();
            string nombre = txtCliente.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string cedula = txtCedula.Text;

            string cadena = "insert into clientes(nombre, apellido, dirrecion, cedula) values ('" + nombre + "','" + apellido + "',' " + direccion + "', '" + cedula + "')";


            SqlCommand comando = new SqlCommand(cadena, conexion); comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");

            conexion.Close();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {

        }
    }
}
