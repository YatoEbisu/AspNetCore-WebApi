using AutoMapper;
using Store.Application.DTOs;
using Store.Domain.Entities;

namespace Store.Application.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductResDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
