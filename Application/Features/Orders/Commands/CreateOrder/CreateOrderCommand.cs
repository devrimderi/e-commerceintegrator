using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Orders.Commands.CreateOrder
{
    public partial class CreateOrderCommand : IRequest<Response<int>>
    {
        public string OrderNumber { get; set; }
        public string IncomingOrderNumber { get; set; }
        
    }
    public class CreateProductCommandHandler : IRequestHandler<CreateOrderCommand, Response<int>>
    {
        private readonly IGenericRepositoryAsync<Order> _orderRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IGenericRepositoryAsync<Order> orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);
            await _orderRepository.AddAsync(order);
            return new Response<int>(order.Id);
        }
    }
}
