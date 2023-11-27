using System.Data;
using System.Security.Cryptography.X509Certificates;
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

        //clase para obtener el rol global
        public static class ConfiguracionUsuario
        {
            public static string Rol { get; set; }
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
                ConfiguracionUsuario.Rol = rol;

               // if (rol == "admin")
               // {
                    AbrirFormularioGestiones("Administrador");
               // }
              //  else
               // {
                    // Abre otro formulario
                  //  AbrirFormularioVentas("Usuario");
               // }

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

        private void AbrirFormularioVentas()
        {
            FrmVentas formV = new FrmVentas();
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}