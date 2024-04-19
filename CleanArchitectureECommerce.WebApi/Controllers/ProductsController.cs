using CleanArchitecture.Application.Products.Queries;
using CleanArchitectureECommerce.Application.Products.Commands;
using CleanArchitectureECommerce.Application.Products.Queries;
using CleanArchitectureECommerce.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IMediator mediator, ILogger<ProductsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        /// <summary>
        /// Retrieves all products from the database.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            _logger.LogInformation("Retrieving all products");
            var query = new GetAllProductsQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }

        /// <summary>
        /// Retrieves a product by its ID from the database.
        /// </summary>
        /// <param name="id">The ID of the product to retrieve.</param>
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            _logger.LogInformation("Retrieving product by ID: {ProductId}", id);
            var query = new GetProductByIdQuery { Id = id };
            var product = await _mediator.Send(query);
            if (product == null)
            {
                _logger.LogWarning("Product not found with ID: {ProductId}", id);
                return NotFound();
            }
            return Ok(product);
        }

        /// <summary>
        /// Updates an existing product in the database.
        /// </summary>
        /// <param name="id">The ID of the product to update.</param>
        /// <param name="command">The command containing the updated details of the product.</param>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                _logger.LogWarning("Product ID mismatch in update request");
                return BadRequest();
            }
            _logger.LogInformation("Updating product with ID: {ProductId}", id);
            await _mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Deletes a product from the database.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            _logger.LogInformation("Deleting product with ID: {ProductId}", id);
            var command = new DeleteProductCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
