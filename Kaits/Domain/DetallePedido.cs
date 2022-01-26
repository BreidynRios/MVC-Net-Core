namespace Domain
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
