using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;
        public ProductoService(IProductoRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductoDto>> List()
        {
            var clientes = await _productoRepository.List();
            return _mapper.Map<IEnumerable<ProductoDto>>(clientes);
        }
    }
}
