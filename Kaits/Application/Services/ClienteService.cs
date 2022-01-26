using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteDto>> List()
        {
            var clientes = await _clienteRepository.List();
            return _mapper.Map<IEnumerable<ClienteDto>>(clientes);
        }
    }
}
