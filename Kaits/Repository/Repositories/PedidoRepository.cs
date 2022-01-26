using DataAccess.Context;
using Domain;
using Repository.Interfaces;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DBKaitsContext _context;
        public PedidoRepository(DBKaitsContext context)
        {
            _context = context;
        }

        public async Task Save(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }
    }
}
