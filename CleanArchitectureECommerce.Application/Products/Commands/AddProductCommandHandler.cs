using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitectureECommerce.Core.Entities;
using CleanArchitectureECommerce.Core.Interfaces;
using CleanArchitecture.Application.Products.Commands;

namespace CleanArchitectureECommerce.Application.Products.Commands
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        private readonly IProductRepository _productRepository;

        public AddProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            await _productRepository.AddAsync(product);
            return product.Id; 
        }
    }
}


