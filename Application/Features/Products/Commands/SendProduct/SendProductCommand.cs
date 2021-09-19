using Application.Interfaces.Repositories;
using Application.MarketPlaceServices.ProductService.Trendyol;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Services.MarketPlaceServices.ProductService;

namespace Application.Features.Products.Commands.SendProduct
{
    public partial class SendProductCommand : IRequest<Response<int>>
    {
        public int ProductId { get; set; }
        public bool SendToTrendyol { get; set; }
        public bool SendToHepsiburada { get; set; }
    }
    public class SendProductCommandCommandHandler : IRequestHandler<SendProductCommand, Response<int>>
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        private readonly ITrendyolProductService _trendyolProductService;

        public SendProductCommandCommandHandler(IProductRepositoryAsync productRepository, IMapper mapper, ITrendyolProductService trendyolProductService)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _trendyolProductService = trendyolProductService;
        }

        public async Task<Response<int>> Handle(SendProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.ProductId);

            //Map Product Entity to Trendyol API Model
            TrendyolProductInputModel inputModel = new TrendyolProductInputModel();
            _trendyolProductService.Create(inputModel);

            return new Response<int>(product.Id);
        }

        public static void GetInputModel(int pazaryeriId)
        {
            if(pazaryeriId == 1)//HB
            {
                //Map TO HB MOdel
            }
        }
    }  
    
        
}
