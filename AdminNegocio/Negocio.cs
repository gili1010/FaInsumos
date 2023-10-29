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

        // Método para ingresar un producto
        public void N_InsertarProducto(AdminEntidades.ClassEntidades producto)
        {
            objd.InsertarProducto(producto.CodigoProducto, producto.DescripcionProducto, producto.StockProducto);
        }

        // Método para mostrar un producto por ID
        public DataTable N_MostrarProductoPorCod(int productoCod)
        {
            return objd.MostrarProductoPorCod(productoCod);
        }

        // Método para modificar un producto
        public void N_ModificarProducto(string codigo, string nuevaDescripcion, int nuevoStock)
        {
            objd.ModificarProducto(codigo, nuevaDescripcion, nuevoStock);
        }

        // Método para eliminar un producto
        public void N_EliminarProductoPorCodigo(string codigo)
        {
            objd.EliminarProductoPorCodigo(codigo);
        }

    }
}