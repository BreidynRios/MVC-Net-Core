using Application.Dtos;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPedidoService
    {
        Task<bool> Save(PedidoDto pedido);
    }
}
