using System;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CleanArchitectureECommerce.Core.Entities;
using CleanArchitectureECommerce.Core.Interfaces;
using CleanArchitecture.Application.Products.Commands;

namespace CleanArchitectureECommerce.Application.Products.Commands
{
    /// <summary>
    /// Handles the command to add a new product to the database.
    /// This handler is responsible for executing the AddProductCommand.
    /// </summary>
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        private readonly IProductRepository _productRepository; // Repository to interact with product data
        private readonly ILogger<AddProductCommandHandler> _logger; // Logger instance

        /// <summary>
        /// Initializes a new instance of the AddProductCommandHandler class.
        /// Injects dependencies for the product repository and logging.
        /// </summary>
        /// <param name="productRepository">The product repository.</param>
        /// <param name="logger">The logger used to log information and errors.</param>
        public AddProductCommandHandler(IProductRepository productRepository, ILogger<AddProductCommandHandler> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        /// <summary>
        /// Processes the given AddProductCommand to add a new product to the database.
        /// Logs the process and handles exceptions.
        /// </summary>
        /// <param name="request">The command request containing the product details.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The ID of the newly added product.</returns>
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

                await _productRepository.AddAsync(product);
                _logger.LogInformation("Product added successfully with ID {ProductId}", product.Id);
                return product.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to add product: {ProductName}", request.Name);
                throw; 
            }
        }
    }
}
