using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFront
{
    public partial class FrmVentas : Form
    {

        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (int.TryParse(txtCodigo.Text, out int codigoProducto)) {

            obje.StockProducto = codigoProducto;
            dt = objn.N_MostrarProductoPorCod(codigoProducto);

            // Asignar el DataTable al DataGridView (suponiendo que tienes un DataGridView llamado dataGridView1 en tu formulario)
            dataGridView1.DataSource = dt;
        }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }
    }
}
