using System.Data;
using System.Windows.Forms;
using WinFormsFront;

namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        AdminEntidades.ClassEntidades obje = new AdminEntidades.ClassEntidades();
        AdminNegocio.Negocio objn = new AdminNegocio.Negocio();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            obje.usu1 = txtUsuario.Text;
            obje.pass1 = txtContraseña.Text;
            dt = objn.N_login(obje);

            if (dt.Rows.Count > 0)
            {
                obje.usu1 = dt.Rows[0][1].ToString();
                obje.pass1 = dt.Rows[0][0].ToString();

                string rol = dt.Rows[0]["Rol"].ToString();

                if (rol == "admin")
                {
                    AbrirFormularioGestiones("Administrador");
                }
                else
                {
                    // Abre otro formulario
                    AbrirFormularioVentas("Usuario");
                }

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intenta de nuevo.");
                LimpiarCampos();
            }
        }

        private void AbrirFormularioGestiones(String rol)
        {
            FrmGestiones formG = new FrmGestiones(rol);
            this.Hide();
            formG.Show();
        }

        private void AbrirFormularioVentas(String rol)
        {
            FrmVentas formV = new FrmVentas(rol);
            this.Hide();
            formV.Show();
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}