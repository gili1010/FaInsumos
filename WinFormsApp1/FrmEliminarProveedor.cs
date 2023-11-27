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
    public partial class FrmEliminarProveedor : Form
    {
        string rol = ConfiguracionUsuario.Rol;

        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();

        public FrmEliminarProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (TryParseCuit(txtCuit.Text, out string codigoProveedor))
            {
                // Aquí llamas al método N_MostrarProveedor de tu clase de negocio
                // Asegúrate de que objn sea una instancia de tu clase de negocio
                dt = objn.N_MostrarProveedor(codigoProveedor);

                if (dt.Rows.Count > 0)
                {
                    // Si se encontró el proveedor, asigna los valores a los TextBox
                    txtCuit.Text = dt.Rows[0]["cuit"].ToString();
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
            txtCuit.Clear();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que se haya seleccionado un producto
            DataTable dt = new DataTable();

            // Obtener los valores del formulario
            string codigoProducto = txtCuit.Text;
            {
                // Muestra un cuadro de diálogo de confirmación
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        // Llama al método de la capa de negocio para eliminar el producto
                        objn.N_EliminarProveedor(codigoProducto);

                        // Muestra un mensaje de éxito
                        MessageBox.Show("Proveedor eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCuit.Clear();
                        txtRZ.Clear();
                        txtContacto.Clear();
                        txtDireccion.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el proveedor. Detalles del error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
