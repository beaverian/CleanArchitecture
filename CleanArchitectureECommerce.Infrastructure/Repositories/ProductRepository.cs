using CleanArchitectureECommerce.Core.Entities;
using CleanArchitectureECommerce.Core.Interfaces;
using CleanArchitectureECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureECommerce.Infrastructure.Repositories
{
    /// <summary>
    /// The ProductRepository is responsible for performing database operations
    /// for the Product entity, implementing the IProductRepository interface.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductRepository> _logger;

        /// <summary>
        /// Initializes a new instance of the ProductRepository with a given database context and logger.
        /// </summary>
        /// <param name="context">The database context to be used for data operations.</param>
        /// <param name="logger">The logger for logging messages within the repository.</param>
        public ProductRepository(ApplicationDbContext context, ILogger<ProductRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Retrieves a product by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to retrieve.</param>
        /// <returns>The found Product or null if no product is found.</returns>
        public async Task<Product> GetByIdAsync(int id)
        {
            try
            {
                _logger.LogInformation("Fetching product with ID {ProductId}", id);
                return await _context.Products.FindAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred when getting the product by ID: {ProductId}", id);
                throw;
            }
        }

        /// <summary>
        /// Retrieves all products from the database.
        /// </summary>
        /// <returns>A list of all Products.</returns>
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            try
            {
                _logger.LogInformation("Retrieving all products from the database");
                return await _context.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred when getting all products");
                throw;
            }
        }

        /// <summary>
        /// Adds a new product to the database.
        /// </summary>
        /// <param name="product">The product to add.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task AddAsync(Product product)
        {
            try
            {
                _logger.LogInformation("Adding a new product: {ProductName}", product.Name);
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred when adding a new product: {ProductName}", product.Name);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing product in the database.
        /// </summary>
        /// <param name="product">The product with updated information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task UpdateAsync(Product product)
        {
            try
            {
                _logger.LogInformation("Updating product: {ProductId}", product.Id);
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred when updating the product: {ProductId}", product.Id);
                throw;
            }
        }

        /// <summary>
        /// Deletes a product from the database.
        /// </summary>
        /// <param name="product">The product to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task DeleteAsync(Product product)
        {
            try
            {
                _logger.LogInformation("Deleting product: {ProductId}", product.Id);
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred when deleting the product: {ProductId}", product.Id);
                throw;
            }
        }
    }
}
