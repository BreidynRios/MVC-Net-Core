using DataAccess.Context;
using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DBKaitsContext _context;
        public ClienteRepository(DBKaitsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> List()
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
