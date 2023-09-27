using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FA_INSUMOS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string email = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Realizar la validación de credenciales en tu base de datos
            //prueba de git
            if (ValidarCredenciales(email, contraseña))
            {
                // Las credenciales son válidas, permitir el acceso a "form x"
                frmGestiones formG = new frmGestiones();
                this.Hide();  // Ocultar el formulario de inicio de sesión
                formG.Show();  // Mostrar el formulario "x"
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
            }

        }
        private bool ValidarCredenciales(string email, string contraseña)
        {
            // Configurar la cadena de conexión a tu base de datos SQL Server
            string connectionString = "Data Source=DESKTOP-VGV3DBL\\SQLEXPRESS;Initial Catalog=fa_insumos;Integrated Security=True;";

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Consulta SQL para verificar las credenciales
                string query = "SELECT COUNT(*) FROM usuarios WHERE Email = @Email AND Contraseña = @Contraseña";

                // Crear un comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    // Ejecutar la consulta y obtener el resultado
                    int count = (int)command.ExecuteScalar();

                    // Si count es mayor que 0, las credenciales son válidas
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}