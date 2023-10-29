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
    public partial class FrmBuscarProd : Form
    {
        string rol = ConfiguracionUsuario.Rol;


        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();
        public FrmBuscarProd()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (int.TryParse(txtIngresarCod.Text, out int codigoProducto))
            {
                obje.StockProducto = codigoProducto;
                dt = objn.N_MostrarProductoPorCod(codigoProducto);

                if (dt.Rows.Count > 0)
                {
                    // Si se encontró el producto, asigna los valores a los TextBox
                    txtTraerCod.Text = dt.Rows[0]["Codigo"].ToString();
                    txtTraerDesc.Text = dt.Rows[0]["Descripcion"].ToString();
                    txtTraerStock.Text = dt.Rows[0]["Stock"].ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                    txtTraerCod.Clear();
                    txtTraerDesc.Clear();
                    txtTraerStock.Clear();
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
