using Domain;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IPedidoRepository
    {
        Task Save(Pedido pedido);
    }
}
