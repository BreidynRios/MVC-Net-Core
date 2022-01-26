using Application.Dtos;
using AutoMapper;
using Domain;

namespace Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Producto, ProductoDto>()
                .ReverseMap();

            CreateMap<Cliente, ClienteDto>()
                .ForMember(d => d.NombreCompleto, opt => opt.MapFrom(src => $"{src.Nombres} {src.ApellidoPaterno} {src.ApellidoMaterno}"))
                .ReverseMap()
                .ForPath(s => s.Pedidos, opt => opt.Ignore());
        }
    }
}
