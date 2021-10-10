using Application.Features.Countries.Commands.CreateCountry;
using Application.Features.Orders.Commands.CreateOrder;
using Application.Features.Products.Commands.CreateProduct;
using Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            //Country
            CreateMap<CreateCountryCommand, Country>();

            //Product
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();

            //Order
            CreateMap<CreateOrderCommand, Order>();

        }
    }
}
