using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsFront;
using static WinFormsApp1.FrmLogin;

namespace WinFormsApp1
{
    public partial class FrmGestiones : Form
    {
        string rol = ConfiguracionUsuario.Rol;

        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();

        public FrmGestiones(string Rol)
        {
            InitializeComponent();

            // Mostrar el rol en el Label correspondiente en FrmGestiones
            labelRol.Text = "Rol: " + rol; // Ajusta el nombre del Label según corresponda
        }

        private void FrmGestiones_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //buscar producto
        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioBuscarProducto();
        }

        //agregar producto
        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarProducto();
        }

        //modificar producto
        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModificarProducto();
        }

        //PROVEEDOR 
        //Buscar proveedor
        private void buscarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedorBuscar formPBP = new FrmProveedorBuscar();
            this.Hide();
            formPBP.Show();
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rol == "admin")
            {
                FrmProveedorAgregar formPBP = new FrmProveedorAgregar();
                this.Hide();
                formPBP.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso para Agregar un proveedor");
            }
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rol == "admin")
            {
                FrmModificarProducto formMP = new FrmModificarProducto();
                this.Hide();
                formMP.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso para modificar un proveedor");
            }
        }
        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rol == "admin")
            {
                FrmEliminarProveedor formEP = new FrmEliminarProveedor();
                this.Hide();
                formEP.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso para eliminar un proveedor");
            }
        }

        private void AbrirFormularioAgregarProducto()
        {
            if (rol == "admin")
            {
                FrmAgregarProd formAP = new FrmAgregarProd();
                this.Hide();
                formAP.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso para Agregar un producto");
            }
        }
        private void AbrirFormularioBuscarProducto()
        {
            FrmBuscarProd formBP = new FrmBuscarProd();
            this.Hide();
            formBP.Show();
        }
        private void AbrirFormularioModificarProducto()
        {
            if (rol == "admin")
            {
                FrmModificarProd formMP = new FrmModificarProd();
                this.Hide();
                formMP.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso para modificar un producto");
            }
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rol == "admin")
            {
                FrmEliminarProducto formEP = new FrmEliminarProducto();
                this.Hide();
                formEP.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso para eliminar un producto");
            }
        }

        private void eliminarProveedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (rol == "admin")
            {
                FrmEliminarProveedor formEP = new FrmEliminarProveedor();
                this.Hide();
                formEP.Show();
            }
            else
            {
                MessageBox.Show("No tienes acceso para eliminar un proveedor");
            }
        }

        private void mostrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarProveedores formMp = new FrmMostrarProveedores();
            this.Hide();
            formMp.Show();
        }

        private void mostrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarProductos formMp = new FrmMostrarProductos();
            this.Hide();
            formMp.Show();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaVenta formVentas = new FrmNuevaVenta();
            this.Hide();
            formVentas.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaVenta formVentas = new FrmNuevaVenta();
            this.Hide();
            formVentas.Show();
        }

        private void historialVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorialVenta formVentas = new FrmHistorialVenta();
            this.Hide();
            formVentas.Show();
        }
    }
}
