using EcommerceAPI.Application.DTOs;

namespace EcommerceAPI.Application.Services.Interfaces
{
    public interface IPersonService
    {
        Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO);
    }
}
