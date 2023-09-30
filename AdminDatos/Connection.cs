using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AdminEntidades;

namespace AdminDatos
{
    public class Connection
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=fa_insumos;Integrated Security=True;");

        public DataTable D_Login(Class1 Obje)
        {
            SqlCommand command = new SqlCommand("sp_login", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@usu", Obje.usu1);
            command.Parameters.AddWithValue("@pas", Obje.pass1);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}