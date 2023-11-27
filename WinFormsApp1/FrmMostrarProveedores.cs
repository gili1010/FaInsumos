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
using AdminNegocio;
using static WinFormsApp1.FrmLogin;
using System.Runtime.Intrinsics.X86;

namespace WinFormsFront
{
    public partial class FrmMostrarProveedores : Form
    {
        string rol = ConfiguracionUsuario.Rol;


        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();
        public FrmMostrarProveedores()
        {
            InitializeComponent();
        }

        //Buscar un cuit del listado
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            // Llamar al método de la capa de negocio para obtener todos los proveedores
            dt = objn.N_MostrarProveedor(txtBuscar.Text);

            // Asignar el DataTable al DataGridView (suponiendo que tienes un DataGridView llamado dataGridView1 en tu formulario)
            dataGridView1.DataSource = dt;

            // Si no se encontró el CUIT, mostrar un mensaje de error
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el CUIT.");
                Listar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }

        private void Listar()
        {
            DataTable dt = new DataTable();

            // Llamar al método de la capa de negocio para obtener todos los proveedores
            dt = objn.N_ListarProveedores();

            // Asignar el DataTable al DataGridView (suponiendo que tienes un DataGridView llamado dataGridView1 en tu formulario)
            dataGridView1.DataSource = dt;
        }

        private void FrmMostrarProveedores_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void ImprimirProveedor(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Crea una nueva fuente llamada "texto" con el estilo Arial, tamaño 10 y negrita
            Font texto = new Font("Arial", 12, FontStyle.Bold);

            // Get the data table
            DataTable dt = dataGridView1.DataSource as DataTable;

            // Calcula la posición inicial para la impresión en el eje Y
            float yPos = e.MarginBounds.Top;


            // Dibuja el texto de encabezado centrado
            float anchoTexto = e.Graphics.MeasureString("Listado de proveedores", texto).Width;
            e.Graphics.DrawString("Listado de proveedores", texto, Brushes.Black, (e.MarginBounds.Width - anchoTexto) / 2, yPos);

            // Aumenta la posición en el eje Y para el siguiente texto
            yPos += e.Graphics.MeasureString("Listado de proveedores", texto).Height + 10;

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

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
