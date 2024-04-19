using CleanArchitectureECommerce.Core.Entities;
using CleanArchitectureECommerce.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureECommerce.Application.Services
{
    /// <summary>
    /// Service for managing product-related operations.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        /// <summary>
        /// Initializes a new instance of the ProductService class.
        /// </summary>
        /// <param name="productRepository">The product repository.</param>
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Retrieves all products from the database.
        /// </summary>
        /// <returns>A collection of products.</returns>
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        /// <summary>
        /// Retrieves a product by its ID from the database.
        /// </summary>
        /// <param name="productId">The ID of the product to retrieve.</param>
        /// <returns>The product with the specified ID.</returns>
        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _productRepository.GetByIdAsync(productId);
        }

        /// <summary>
        /// Adds a new product to the database.
        /// </summary>
        /// <param name="product">The product to add.</param>
        /// <returns>True if the product was added successfully, otherwise false.</returns>
        public async Task<bool> AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            return true; 
        }

        /// <summary>
        /// Updates an existing product in the database.
        /// </summary>
        /// <param name="product">The updated product.</param>
        /// <returns>True if the product was updated successfully, otherwise false.</returns>
        public async Task<bool> UpdateProductAsync(Product product)
        {
            var existingProduct = await _productRepository.GetByIdAsync(product.Id);
            if (existingProduct == null)
            {
                return false; 
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            await _productRepository.UpdateAsync(existingProduct);
            return true; 
        }

        /// <summary>
        /// Deletes a product from the database.
        /// </summary>
        /// <param name="productId">The ID of the product to delete.</param>
        /// <returns>True if the product was deleted successfully, otherwise false.</returns>
        public async Task<bool> DeleteProductAsync(int productId)
        {
            var existingProduct = await _productRepository.GetByIdAsync(productId);
            if (existingProduct == null)
            {
                return false; 
            }

            await _productRepository.DeleteAsync(existingProduct);
            return true; 
        }
    }
}