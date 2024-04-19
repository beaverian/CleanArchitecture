using CleanArchitectureECommerce.Core.Entities;
using CleanArchitectureECommerce.Core.Interfaces;
using CleanArchitectureECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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

        /// <summary>
        /// Initializes a new instance of the ProductRepository with a given database context.
        /// </summary>
        /// <param name="context">The database context to be used for data operations.</param>
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
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
                return await _context.Products.FindAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when getting the product by ID: {ex.Message}");
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
                return await _context.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when getting all products: {ex.Message}");
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
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when adding a new product: {ex.Message}");
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
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when updating the product: {ex.Message}");
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
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when deleting the product: {ex.Message}");
                throw;
            }
        }
    }
}
