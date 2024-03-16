using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitectureECommerce.Core.Interfaces;
using CleanArchitectureECommerce.Application.Dto;

namespace CleanArchitectureECommerce.Application.Products.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            return new ProductDto { Id = product.Id, Name = product.Name, Price = product.Price };
        }
    }
}


