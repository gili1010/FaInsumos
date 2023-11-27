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

        //Metodo para eliminar un producto
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

        //Proveedores

        //Buscar un proveedor
        // Método para mostrar un producto por Cod Producto
        public DataTable MostrarProveedor(string proveedorCuit)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("SPBuscarProveedorPorCUIT", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cuitBuscado", proveedorCuit);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        // Método para ingresar un proveedor
        public void InsertarProveedor(string cuit, string rz, string contacto, string direccion)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("SPAgregarProveedor", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cuit", cuit);
            command.Parameters.AddWithValue("@Rz", rz);
            command.Parameters.AddWithValue("@nombre_contacto", contacto);
            command.Parameters.AddWithValue("@direccion", direccion);
            command.ExecuteNonQuery();
            cn.Close();
        }
        // Método para modificar un proveedor en la base de datos
        public void ModificarProveedor(string cuit, string RZ, string contacto, string direccion)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("ModificarProveedor", cn);
            command.CommandType = CommandType.StoredProcedure; 
            command.Parameters.AddWithValue("@nuevoCuit", cuit);
            command.Parameters.AddWithValue("@nuevaRz", RZ);
            command.Parameters.AddWithValue("@nuevoNombreContacto", contacto);
            command.Parameters.AddWithValue("@nuevaDireccion", direccion);
            command.ExecuteNonQuery();
            cn.Close();
        }


        //Metodo para eliminar un proveedor
        public void EliminarProveedor(string cuit)
        {
            cn.Open();
            using (SqlCommand command = new SqlCommand("EliminarProveedor", cn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cuitBuscado", cuit);
                command.ExecuteNonQuery();
                cn.Close();
            }
        }


        // Método para mostrar proveedores
        public DataTable MostrarProveedoresLista()
        {
            try
            {
                SqlDataReader resultado;
                DataTable dt = new DataTable();
                cn.Open();
                SqlCommand command = new SqlCommand("ObtenerTodosLosProveedores", cn);
                command.CommandType = CommandType.StoredProcedure;
                resultado = command.ExecuteReader();
                //SqlDataAdapter da = new SqlDataAdapter(command);
                dt.Load(resultado);
                //da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                // Manejar la excepción, mostrar un mensaje de error o registrar el error según sea necesario.
                Console.WriteLine($"Error al obtener proveedores: {ex.Message}");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        // Método para mostrar productos
        public DataTable MostrarProductosLista()
        {
            try
            {
                SqlDataReader resultado;
                DataTable dt = new DataTable();
                cn.Open();
                SqlCommand command = new SqlCommand("ObtenerTodosLosProductos", cn);
                command.CommandType = CommandType.StoredProcedure;
                resultado = command.ExecuteReader();
                dt.Load(resultado);

                return dt;
            }
            catch (Exception ex)
            {
                // Manejar la excepción, mostrar un mensaje de error o registrar el error según sea necesario.
                Console.WriteLine($"Error al obtener productos: {ex.Message}");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        // Método para mostrar Ventas
        public DataTable MostrarVentas()
        {
            try
            {
                SqlDataReader resultado;
                DataTable dt = new DataTable();
                cn.Open();
                SqlCommand command = new SqlCommand("ObtenerDatosVentasDetalles", cn);
                command.CommandType = CommandType.StoredProcedure;
                resultado = command.ExecuteReader();
                dt.Load(resultado);

                return dt;
            }
            catch (Exception ex)
            {
                // Manejar la excepción, mostrar un mensaje de error o registrar el error según sea necesario.
                Console.WriteLine($"Error al obtener ventas: {ex.Message}");
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        // Método para ingresar una venta
        public void InsertarVenta(int idUsuario, decimal TotalVenta, int IdProducto, int Cantidad, decimal PrecioUnitario)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("InsertarVenta", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdUsuario", idUsuario);
            command.Parameters.AddWithValue("@TotalVenta", TotalVenta);
            command.Parameters.AddWithValue("@IdProducto", IdProducto);
            command.Parameters.AddWithValue("@Cantidad", Cantidad);
            command.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
            command.ExecuteNonQuery();
            cn.Close();
        }
    }
}