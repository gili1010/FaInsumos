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
    public partial class FrmModificarProd : Form
    {
        string rol = ConfiguracionUsuario.Rol;


        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();
        public FrmModificarProd()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            // Obtener los valores del formulario
            string codigoProducto = txtCodigo.Text;
            string nuevaDescripcion = txtNuevaDescr.Text;
            int nuevoStock;

            if (int.TryParse(txtNuevoStock.Text, out nuevoStock))
            {
                // Llamar al método para modificar el producto
                objn.N_ModificarProducto(codigoProducto, nuevaDescripcion, nuevoStock);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Producto modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Preguntar al usuario si desea modificar más productos
                DialogResult result = MessageBox.Show("¿Deseas modificar otro producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Si el usuario elige "Sí", limpiar los campos y permitir modificar otro producto
                    txtCodigo.Clear();
                    txtNuevaDescr.Clear();
                    txtNuevoStock.Clear();
                }
                else
                {
                    // Si el usuario elige "No", volver al formulario anterior
                    FrmGestiones formG = new FrmGestiones(rol);
                    this.Hide();
                    formG.Show();
                }
            }
            else
            {
                // Manejar el caso en el que el usuario ingresó un valor no válido para el nuevo stock.
                MessageBox.Show("El valor del nuevo stock no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }

        private void txtNuevaDescr_TextChanged(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtNuevoStock_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
