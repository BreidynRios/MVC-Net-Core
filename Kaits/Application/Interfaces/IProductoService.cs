using Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductoService
    {
        Task<IEnumerable<ProductoDto>> List();
    }
}
