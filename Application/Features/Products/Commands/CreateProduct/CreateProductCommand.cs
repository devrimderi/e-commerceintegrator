using Application.Interfaces.MarketPlace.ProductServices;
using Application.Interfaces.Repositories;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Services.MarketPlaceServices.ProductService;

namespace Application.Features.Products.Commands.CreateProduct
{
    public partial class CreateProductCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Response<int>>
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        private readonly ITrendyolProductService _trendyolProductService;

        public CreateProductCommandHandler(IProductRepositoryAsync productRepository, IMapper mapper, ITrendyolProductService trendyolProductService)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _trendyolProductService = trendyolProductService;
        }

        public async Task<Response<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _productRepository.AddAsync(product);

            //Map Product Command to Trendyol API Model
            TrendyolProductInputModel inputModel = new TrendyolProductInputModel();            
            _trendyolProductService.Create(inputModel);

            return new Response<int>(product.Id);
        }
    }
}
