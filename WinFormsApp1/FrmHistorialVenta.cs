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
    public partial class FrmHistorialVenta : Form
    {
        string rol = ConfiguracionUsuario.Rol;

        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();
        public FrmHistorialVenta()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            DataTable dt = new DataTable();

            // Llamar al método de la capa de negocio para obtener todos los productos
            dt = objn.N_MostrarVentas();

            // Asignar el DataTable al DataGridView (suponiendo que tienes un DataGridView llamado dataGridView1 en tu formulario)
            dataGridView1.DataSource = dt;
        }

        private void FrmHistorialVenta_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }
    }
}
