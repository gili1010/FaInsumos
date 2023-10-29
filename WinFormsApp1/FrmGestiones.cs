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

namespace WinFormsApp1
{
    public partial class FrmGestiones : Form
    {
        public FrmGestiones(string rol)
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


        private void AbrirFormularioAgregarProducto()
        {
            FrmAgregarProd formAP = new FrmAgregarProd();
            this.Hide();
            formAP.Show();
        }
        private void AbrirFormularioBuscarProducto()
        {
            FrmBuscarProd formBP = new FrmBuscarProd();
            this.Hide();
            formBP.Show();
        }
        private void AbrirFormularioModificarProducto()
        {
            FrmModificarProd formMP = new FrmModificarProd();
            this.Hide();
            formMP.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarProducto formEP = new FrmEliminarProducto();
            this.Hide();
            formEP.Show();
        }
    }
}
