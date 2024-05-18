using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_dionicia
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            
            string Rutaconexion = null;
            SqlConnection Conexion;
            string consulta = null;
            InitializeComponent();

            Rutaconexion = @"Data Source=CHRISTOPHERTOD1;Initial Catalog=ventas;Persist Security Info=True;User ID=sa;Password=1234; ";
            Conexion = new SqlConnection(Rutaconexion);
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection("server =CHRISTOPHERTOD1 ;database= ventas ; integrated security = true");
            conexion.Open();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
              
            string cedula = txtCedula.Text;
            string PagoEmpleado = textPagoEmpleado.Text;
            string contrato = texContrato.Text;
            string InicioLaboral = text_Inicio_laboral.Text;
            string SalidaLaboral= text_Salida_laboral.Text;
            string sexo = textSexo.Text;
           

            string cadena = "insert into empleados(nombre, apellido,  cedula, pago_empleado, contrato,inicio_laboral,salida_laboral,sexo ) values ('" + nombre + "','" + apellido + "',' " + cedula + "', '" +  PagoEmpleado + "','" + contrato + "','" + InicioLaboral + "',' " + SalidaLaboral + "', '" + sexo + "')";


            SqlCommand comando = new SqlCommand(cadena, conexion); comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");

            conexion.Close();

        }

        private void textCargo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
