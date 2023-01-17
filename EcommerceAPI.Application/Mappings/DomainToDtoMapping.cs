using AutoMapper;
using EcommerceAPI.Application.DTOs;
using EcommerceAPI.Domain.Entities;

namespace EcommerceAPI.Application.Mappings
{
    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping() 
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<Product, ProductDTO>();
        }
    }
}
