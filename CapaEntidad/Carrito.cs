namespace CapaEntidad
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public Cliente OCliente { get; set; }
        public Producto OProducto { get; set; }
        public int Cantidad { get; set; }
    }
}