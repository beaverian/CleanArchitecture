using CleanArchitectureECommerce.Application.Services;
using CleanArchitectureECommerce.Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureECommerce.Application.Products.Commands
{
    /// <summary>
    /// Handles the UpdateProductCommand to update an existing product.
    /// </summary>
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductService _productService;

        public UpdateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = request.Id,
                Name = request.Name,
                Price = request.Price
            };

            // Delegate the task to the ProductService
            return await _productService.UpdateProductAsync(product);
        }
    }
}
