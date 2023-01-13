using AutoMapper;
using EcommerceAPI.Application.DTOs;
using EcommerceAPI.Domain.Entities;

namespace EcommerceAPI.Application.Mappings
{
    public class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping()
        {
            CreateMap<PersonDTO, Person>();
        }
    }
}
