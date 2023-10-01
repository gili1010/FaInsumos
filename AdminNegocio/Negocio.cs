using System.Data;

namespace AdminNegocio
{
    public class Negocio
    {
        AdminDatos.Connection objd = new AdminDatos.Connection();

        public DataTable N_login(AdminEntidades.ClassEntidades Obje)
        {
            return objd.D_Login(Obje);
        }
    }
}