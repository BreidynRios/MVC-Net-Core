using System.Collections.Generic;

namespace Domain
{
    public class Producto
    {
        public Producto()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
