using DataAccess.Context;
using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly DBKaitsContext _context;
        public ProductoRepository(DBKaitsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> List()
        {
            return await _context.Productos.ToListAsync();
        }
    }
}
