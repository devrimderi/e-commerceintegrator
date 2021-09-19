using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Services.MarketPlaceServices.ProductService;

namespace Application.Interfaces.MarketPlace.ProductServices
{
    public interface ITrendyolProductService
    {
        void Create(TrendyolProductInputModel inputModel);
    }
}
