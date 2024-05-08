using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CleanArchitectureECommerce.Core.Entities;
using CleanArchitectureECommerce.Application.Services;
using CleanArchitectureECommerce.Application.Products.Commands;

namespace CleanArchitectureECommerce.Application.Products.Commands
{
    /// <summary>
    /// Handles the command to add a new product to the database.
    /// This handler delegates the business logic of adding the product to the ProductService.
    /// </summary>
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        private readonly ProductService _productService;
        private readonly ILogger<AddProductCommandHandler> _logger;

        /// <summary>
        /// Initializes a new instance of the AddProductCommandHandler class.
        /// Injects dependencies for the product service and logging.
        /// </summary>
        /// <param name="productService">The service responsible for managing product data.</param>
        /// <param name="logger">The logger used to log information and errors.</param>
        public AddProductCommandHandler(ProductService productService, ILogger<AddProductCommandHandler> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        /// <summary>
        /// Processes the given AddProductCommand to add a new product to the database.
        /// The actual addition logic is handled by the ProductService.
        /// </summary>
        /// <param name="request">The command request containing the product details.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The ID of the newly added product, provided by the ProductService.</returns>
        public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Attempting to add a new product: {ProductName}", request.Name);
            try
            {
                var product = new Product
                {
                    Name = request.Name,
                    Price = request.Price
                };

                bool isAdded = await _productService.AddProductAsync(product);
                if (isAdded)
                {
                    _logger.LogInformation("Product added successfully with ID {ProductId}", product.Id);
                    return product.Id; // Return the product ID if added successfully
                }
                else
                {
                    _logger.LogError("Failed to add product: {ProductName}", request.Name);
                    return -1; // Indicate failure by returning -1 or throw an exception as per business requirement
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to add product: {ProductName}", request.Name);
                throw; // Rethrow the exception to maintain the stack trace
            }
        }
    }
}
