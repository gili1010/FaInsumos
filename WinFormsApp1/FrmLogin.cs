using System.Data;
using System.Windows.Forms;

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
                obje.usu1 = dt.Rows[0][4].ToString();
                obje.pass1 = dt.Rows[0][5].ToString();
                AbrirFormularioGestiones();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intenta de nuevo.");
                LimpiarCampos();
            }
        }

        private void AbrirFormularioGestiones()
        {
            FrmGestiones formG = new FrmGestiones();
            this.Hide();
            formG.Show();
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }
    }
}