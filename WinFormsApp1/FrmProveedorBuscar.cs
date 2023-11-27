using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static WinFormsApp1.FrmLogin;

namespace WinFormsFront
{
    public partial class FrmProveedorBuscar : Form
    {
        string rol = ConfiguracionUsuario.Rol;

        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();

        public FrmProveedorBuscar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (TryParseCuit(txtIngresarCuit.Text, out string codigoProveedor))
            {
                // Aquí llamas al método N_MostrarProveedor de tu clase de negocio
                // Asegúrate de que objn sea una instancia de tu clase de negocio
                dt = objn.N_MostrarProveedor(codigoProveedor);

                if (dt.Rows.Count > 0)
                {
                    // Si se encontró el proveedor, asigna los valores a los TextBox
                    txtTraerCuit.Text = dt.Rows[0]["cuit"].ToString();
                    txtRZ.Text = dt.Rows[0]["RZ"].ToString();
                    txtContacto.Text = dt.Rows[0]["nombre_contacto"].ToString();
                    txtDireccion.Text = dt.Rows[0]["direccion"].ToString();
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado");
                    LimpiarTextBox();
                }
            }
            else
            {
                // Manejar el caso en el que el usuario ingresó un valor no válido para el CUIT.
                MessageBox.Show("El valor del CUIT no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los TextBox
        private void LimpiarTextBox()
        {
            txtTraerCuit.Clear();
            txtRZ.Clear();
            txtContacto.Clear();
            txtDireccion.Clear();
        }

        // Método para intentar analizar el CUIT
        private bool TryParseCuit(string input, out string cuit)
        {
            // Lógica para validar y formatear el CUIT según tus necesidades
            // Devuelve true si el análisis es exitoso, de lo contrario, false.

            // En este ejemplo, simplemente asignamos el valor sin realizar validaciones adicionales.
            cuit = input;
            return true;
        }
    }
}
