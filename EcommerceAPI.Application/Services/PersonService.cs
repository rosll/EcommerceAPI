using AutoMapper;
using EcommerceAPI.Application.DTOs;
using EcommerceAPI.Application.DTOs.Validations;
using EcommerceAPI.Application.Services.Interfaces;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Domain.Repositories;

namespace EcommerceAPI.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO)
        {
            if (personDTO == null)
                return ResultService.Fail<PersonDTO>("Objeto deve ser informado");

            var result = new PersonDTOValidator().Validate(personDTO);

            if (!result.IsValid)
                return ResultService.RequestError<PersonDTO>("Problemas de validação", result);

            var person = _mapper.Map<Person>(personDTO);
            var data = await _personRepository.CreateAsync(person);
            return ResultService.Ok<PersonDTO>(_mapper.Map<PersonDTO>(data));
        }
    }
}
