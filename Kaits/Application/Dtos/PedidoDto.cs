using System.Collections.Generic;

namespace Application.Dtos
{
    public class PedidoDto
    {
        public int CodigoCliente { get; set; }
        public ICollection<DetallePedidoDto> DetallePedido { get; set; }
    }
}
