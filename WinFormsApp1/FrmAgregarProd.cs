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

    public partial class FrmAgregarProd : Form

    {
        string rol = ConfiguracionUsuario.Rol;


        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();

        public FrmAgregarProd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgregarProd_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Agregar Producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.CodigoProducto = txtCodigo.Text;
            obje.DescripcionProducto = txtDesc.Text;

            if (int.TryParse(txtStock.Text, out int stock))
            {
                obje.StockProducto = stock;
                objn.N_InsertarProducto(obje);

                // Después de agregar el producto, mostrar una caja de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Deseas agregar otro producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Si el usuario elige "Sí", limpiar los campos y permitir agregar otro producto
                    txtCodigo.Clear();
                    txtDesc.Clear();
                    txtStock.Clear();
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
                // Manejar el caso en el que el usuario ingresó un valor no válido para el stock.
                MessageBox.Show("El valor del stock no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }
    }
}
