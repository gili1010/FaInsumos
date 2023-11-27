using AdminEntidades;
using AdminNegocio;
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
    public partial class FrmNuevaVenta : Form
    {
        string rol = ConfiguracionUsuario.Rol;
        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();
        private List<Venta> listaProductos = new List<Venta>(); // Agrega esta línea
        public FrmNuevaVenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }

        private void btnCofirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos de los controles en tu formulario
                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);
                int idProducto = Convert.ToInt32(txtIdProducto.Text);
                string descripcion = txtDescripcion.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                decimal totalVenta = Convert.ToDecimal(cantidad * precioUnitario);

                // Crear una instancia de la clase Venta
                Venta venta = new Venta
                {
                    IdUsuario = idUsuario,
                    TotalVenta = totalVenta,
                    IdProducto = idProducto,
                    descripcion = descripcion,
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario
                };

                // Agregar la venta a la lista de productos
                listaProductos.Add(venta);

                // Limpiar los controles de entrada
                LimpiarControlesEntrada();

                // Mostrar la lista de productos en la grilla
                ActualizarGrillaProductos();

                // Llamar al método de la capa de negocio para insertar la venta
                // objn.N_InsertarVentas(idUsuario, totalVenta, idProducto, cantidad, precioUnitario);

                // MessageBox.Show("Venta insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControlesEntrada()
        {
            txtIdProducto.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            stock.Clear();
        }

        private void ActualizarGrillaProductos()
        {
            // Limpiar la grilla
            dataGridView1.Rows.Clear();

            // Mostrar los productos en la grilla
            foreach (Venta producto in listaProductos)
            {
                dataGridView1.Rows.Add(
                    producto.IdUsuario,
                    producto.TotalVenta,
                    producto.IdProducto,
                    producto.descripcion,
                    producto.Cantidad,
                    producto.PrecioUnitario
                );
            }
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Insertar todos los productos en la base de datos
                foreach (Venta producto in listaProductos)
                {
                    objn.N_InsertarVentas(producto.IdUsuario, producto.TotalVenta, producto.IdProducto, producto.Cantidad, producto.PrecioUnitario);
                }


                // Limpiar la lista de productos y la grilla
                listaProductos.Clear();
                dataGridView1.Rows.Clear();

                MessageBox.Show("Ventas insertadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (int.TryParse(txtIdProducto.Text, out int codigoProducto))
            {
                obje.StockProducto = codigoProducto;
                dt = objn.N_MostrarProductoPorCod(codigoProducto);

                if (dt.Rows.Count > 0)
                {
                    // Si se encontró el producto, asigna los valores a los TextBox
                    txtDescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
                    stock.Text = dt.Rows[0]["Stock"].ToString();
                    txtPrecioUnitario.Text =dt.Rows[0]["Precio"].ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                    txtDescripcion.Clear();
                    stock.Clear();
                }
            }
            else
            {
                // Manejar el caso en el que el usuario ingresó un valor no válido para el stock.
                MessageBox.Show("El valor no es número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
