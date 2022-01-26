namespace Application.Dtos
{
    public class DetallePedidoDto
    {
        public int CodigoProducto { get; set; }
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
