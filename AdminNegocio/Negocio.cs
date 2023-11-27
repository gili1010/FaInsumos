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

        // Método para mostrar un proveedor por Cuit
        public DataTable N_MostrarProveedor(string productoCod)
        {
            return objd.MostrarProveedor(productoCod);
        }

        // Método para ingresar un proveedor
        public void N_InsertarProveedor(AdminEntidades.ClassEntidades proveedor)
        {
            objd.InsertarProveedor(proveedor.cuit, proveedor.RZ, proveedor.nombre_contacto, proveedor.direccion);
        }

        // Método para modificar un proveedor
        public void N_ModificarProveedor(string cuit, string RZ, string contacto, string direccion)
        {
            objd.ModificarProveedor(cuit, RZ, contacto, direccion);
        }

        // Método para eliminar un proveedor
        public void N_EliminarProveedor(string cuit)
        {
            objd.EliminarProveedor(cuit);
        }

        // Método para listar proveedores
        public DataTable N_ListarProveedores()
        {
            return objd.MostrarProveedoresLista();
        }

        // Método para listar productos
        public DataTable N_ListarProductos()
        {
            return objd.MostrarProductosLista();
        }

        // Método para listar ventas
        public DataTable N_MostrarVentas()
        {
            return objd.MostrarVentas();
        }

        // Método para insertar ventas
        public void N_InsertarVentas(int idUsuario, decimal TotalVenta, int IdProducto, int Cantidad, decimal PrecioUnitario)
        {
            objd.InsertarVenta(idUsuario, TotalVenta, IdProducto, Cantidad, PrecioUnitario);
        }

    }
}