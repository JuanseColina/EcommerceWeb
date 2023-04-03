using System.Collections.Generic;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int TotalProductos { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string IdDistrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string FechaTexto { get; set; }
        public string IdTransaccion { get; set; }
        
        public List<DetalleVenta> ODetalleVenta { get; set; }
    }
}