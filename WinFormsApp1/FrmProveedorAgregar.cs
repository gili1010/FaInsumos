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
    public partial class FrmProveedorAgregar : Form
    {
        string rol = ConfiguracionUsuario.Rol;

        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();
        public FrmProveedorAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.cuit = txtCuit.Text;
            obje.RZ = txtRZ.Text;
            obje.nombre_contacto = txtContacto.Text;
            obje.direccion = txtDireccion.Text;

             objn.N_InsertarProveedor(obje);

                // Después de agregar el producto, mostrar una caja de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Deseas agregar otro proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                // Si el usuario elige "Sí", limpiar los campos y permitir agregar otro producto
                txtCuit.Clear();
                txtRZ.Clear();
                txtContacto.Clear();
                txtDireccion.Clear();
            }
                else
                {
                    // Si el usuario elige "No", volver al formulario anterior
                    FrmGestiones formG = new FrmGestiones(rol);
                    this.Hide();
                    formG.Show();
                }
     
        }
    }
}
