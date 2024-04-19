using CleanArchitectureECommerce.Application.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitectureECommerce.Application.Products.Commands
{
    /// <summary>
    /// Handles the DeleteProductCommand to delete a product by its ID.
    /// </summary>
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductService _productService;

        public DeleteProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Handles the DeleteProductCommand to delete a product by its ID.
        /// </summary>
        /// <param name="request">The DeleteProductCommand instance.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A boolean indicating whether the product was successfully deleted.</returns>
        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await _productService.DeleteProductAsync(request.Id);
        }
    }
}
