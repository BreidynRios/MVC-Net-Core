using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> List();
    }
}
