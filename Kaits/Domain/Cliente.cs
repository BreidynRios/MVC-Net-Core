using System.Collections.Generic;

namespace Domain
{
    public class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string DNI { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
