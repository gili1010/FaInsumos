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

            if (ValidarCredenciales(email, contraseña))
            {
                AbrirFormularioGestiones();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intenta de nuevo.");
                LimpiarCampos();
            }

        }
        private bool ValidarCredenciales(string email, string contraseña)
        {
            try
            {
                string connectionString = ObtenerCadenaConexion();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE Email = @Email AND Contraseña = @Contraseña";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al conectar con la base de datos.
                MessageBox.Show("Error al validar credenciales: " + ex.Message);
                return false;
            }
        }

        private string ObtenerCadenaConexion()
        {
            // Obtener la cadena de conexión desde un archivo de configuración o utilizar una constante.
            return "Data Source=localhost;Initial Catalog=fa_insumos;Integrated Security=True;";
        }

        private void AbrirFormularioGestiones()
        {
            frmGestiones formG = new frmGestiones();
            this.Hide();
            formG.Show();
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
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