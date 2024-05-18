using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_dionicia
{
    public partial class FormMenuPrincipal : System.Windows.Forms.Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Form formulario = new FormCliente();
            formulario.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Form formulario = new FormEmpleado();
            formulario.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Form formulario = new FormInventario();
            formulario.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Form formulario = new FormFactura();
            formulario.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
           Form formulario = new FormCliente();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new FormEmpleado();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new FormInventario();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new FormInventario();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
