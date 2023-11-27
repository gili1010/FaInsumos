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
    public partial class FrmMostrarProductos : Form
    {
        string rol = ConfiguracionUsuario.Rol;

        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();

        public FrmMostrarProductos()
        {
            InitializeComponent();
        }

        //regresar
        private void button3_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }

        //Buscar Productos
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int codigoProducto = 0;
            if (int.TryParse(txtBuscar.Text, out codigoProducto))
            {

                dt = objn.N_MostrarProductoPorCod(codigoProducto);
                dataGridView1.DataSource = dt;

            }
            // Si no se encontró el CUIT, mostrar un mensaje de error
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el CUIT.");
                Listar();
            }
        }

        private void Listar()
        {
            DataTable dt = new DataTable();

            // Llamar al método de la capa de negocio para obtener todos los productos
            dt = objn.N_ListarProductos();

            // Asignar el DataTable al DataGridView (suponiendo que tienes un DataGridView llamado dataGridView1 en tu formulario)
            dataGridView1.DataSource = dt;
        }

        private void FrmMostrarProductos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImprimirProducto(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Crea una nueva fuente llamada "texto" con el estilo Arial, tamaño 10 y negrita
            Font texto = new Font("Arial", 12, FontStyle.Bold);

            // Get the data table
            DataTable dt = dataGridView1.DataSource as DataTable;

            // Calcula la posición inicial para la impresión en el eje Y
            float yPos = e.MarginBounds.Top;


            // Dibuja el texto de encabezado centrado
            float anchoTexto = e.Graphics.MeasureString("Listado de productos", texto).Width;
            e.Graphics.DrawString("Listado de proveedores", texto, Brushes.Black, (e.MarginBounds.Width - anchoTexto) / 2, yPos);

            // Aumenta la posición en el eje Y para el siguiente texto
            yPos += e.Graphics.MeasureString("Listado de productos", texto).Height + 10;

            // Recorre cada fila en el DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Restablece la posición inicial en el eje X para cada fila
                float xPos = e.MarginBounds.Left;

                // Recorre cada celda en la fila
                foreach (DataColumn column in dt.Columns)
                {
                    // Dibuja el contenido de la celda
                    e.Graphics.DrawString(row[column].ToString(), texto, Brushes.Black, xPos, yPos);

                    // Calcula la posición en el eje X para la siguiente celda
                    xPos += e.Graphics.MeasureString(row[column].ToString(), texto).Width + 30;
                }

                // Mueve la posición hacia abajo para la siguiente fila
                yPos += e.Graphics.MeasureString(row[0].ToString(), texto).Height + 10;
            }
        }
    }
}
