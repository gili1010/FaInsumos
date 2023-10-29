using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AdminEntidades;

namespace AdminDatos
{
    public class Connection
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=fa_insumos;Integrated Security=True;");

        //Metodo para Iniciar sesion 
        public DataTable D_Login(ClassEntidades Obje)
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

        // Método para ingresar un producto
        public void InsertarProducto(string codigo, string descripcion, int stock)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("InsertarProducto", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Codigo", codigo);
            command.Parameters.AddWithValue("@Descripcion", descripcion);
            command.Parameters.AddWithValue("@Stock", stock);
            command.ExecuteNonQuery();
            cn.Close();
        }

        // Método para mostrar un producto por Cod Producto
        public DataTable MostrarProductoPorCod(int productoId)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("MostrarProductoPorCod", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProductoCod", productoId);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        // Método para modificar un producto en la base de datos
        public void ModificarProducto(string codigo, string nuevaDescripcion, int nuevoStock)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("ModificarProducto", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Codigo", codigo);
            command.Parameters.AddWithValue("@NuevaDescripcion", nuevaDescripcion);
            command.Parameters.AddWithValue("@NuevoStock", nuevoStock);
            command.ExecuteNonQuery();
            cn.Close();
        }

        public void EliminarProductoPorCodigo(string codigoProducto)
        {
                cn.Open();
                using (SqlCommand command = new SqlCommand("EliminarProductoPorCodigo", cn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Codigo", codigoProducto);
                    command.ExecuteNonQuery();
                    cn.Close();
                }
        }


    }
}