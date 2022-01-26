using Application.Dtos;
using Application.Interfaces;
using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public async Task<bool> Save(PedidoDto pedidoDto)
        {
            var detallePedido = new List<DetallePedido>();
            foreach (var item in pedidoDto.DetallePedido)
            {
                detallePedido.Add(new DetallePedido
                {
                    Cantidad = item.Cantidad,
                    PrecioUnitario = item.Precio,
                    Descripcion = item.Descripcion,
                    CodigoProducto = item.CodigoProducto,
                    SubTotal = item.Cantidad * item.Precio
                });
            }
            var pedido = new Pedido
            {
                CodigoCliente = pedidoDto.CodigoCliente,
                Fecha = DateTime.Now,
                Total = detallePedido.Sum(pd => pd.SubTotal),
                DetallePedidos = detallePedido
            };

            await _pedidoRepository.Save(pedido);
            return true;
        }
    }
}
