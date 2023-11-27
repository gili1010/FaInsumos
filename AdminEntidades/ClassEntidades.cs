namespace AdminEntidades
{
    public class ClassEntidades
    {
        public string usu1 {  get; set; }
        public string pass1 { get; set;}
        public string rol { get; set; }

        // Propiedades relacionadas con productos
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int StockProducto { get; set; }
        public int IdProducto { get; set; }
        public float Precio { get; set; }
        public string cuitEmpresa { get; set; }

        // Propiedades relacionadas con proveedores
        public string cuit { get; set; }
        public string RZ { get; set; }
        public string nombre_contacto { get; set; }
        public string direccion { get; set; }

    }

    // Clase en la capa de entidades
    public class Venta
    {
        public int IdUsuario { get; set; }
        public decimal TotalVenta { get; set; }
        public int IdProducto { get; set; }

        public string descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }

}
