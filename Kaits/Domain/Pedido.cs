using System;
using System.Collections.Generic;

namespace Domain
{
    public class Pedido
    {
        public Pedido()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }
        public int IdOrden { get; set; }
        public int CodigoCliente { get; set; }
        public DateTime Fecha { get; set; }       
        public decimal Total { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
