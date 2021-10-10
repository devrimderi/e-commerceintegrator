using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Countries.Commands.CreateCountry
{
    public partial class CreateCountryCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string PhoneCode { get; set; }

    }
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, Response<int>>
    {
        private readonly IGenericRepositoryAsync<Country> _countryRepository;
        private readonly IMapper _mapper;

        public CreateCountryCommandHandler(IGenericRepositoryAsync<Country> countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            var country = _mapper.Map<Country>(request);
            await _countryRepository.AddAsync(country);

            return new Response<int>(country.Id);
        }
    }
}
