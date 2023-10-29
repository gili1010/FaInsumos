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
    public partial class FrmEliminarProducto : Form
    {
        string rol = ConfiguracionUsuario.Rol;


        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();
        public FrmEliminarProducto()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que se haya seleccionado un producto
            DataTable dt = new DataTable();

            // Obtener los valores del formulario
            string codigoProducto = txtCodigo.Text;
            {
                // Muestra un cuadro de diálogo de confirmación
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        // Llama al método de la capa de negocio para eliminar el producto
                        objn.N_EliminarProductoPorCodigo(codigoProducto);

                        // Muestra un mensaje de éxito
                        MessageBox.Show("Producto eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCodigo.Clear();
                        txtNuevaDescr.Clear();
                        txtNuevoStock.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto. Detalles del error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (int.TryParse(txtCodigo.Text, out int codigoProducto))
            {
                obje.StockProducto = codigoProducto;
                dt = objn.N_MostrarProductoPorCod(codigoProducto);

                if (dt.Rows.Count > 0)
                {
                    // Si se encontró el producto, asigna los valores a los TextBox
                    txtNuevaDescr.Text = dt.Rows[0]["Descripcion"].ToString();
                    txtNuevoStock.Text = dt.Rows[0]["Stock"].ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                    txtCodigo.Clear();
                    txtNuevaDescr.Clear();
                    txtNuevoStock.Clear();
                }
            }
            else
            {
                // Manejar el caso en el que el usuario ingresó un valor no válido para el stock.
                MessageBox.Show("El valor del stock no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cancelar, vuelve a la vista de Gestiones
        private void button1_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }
    }
}
