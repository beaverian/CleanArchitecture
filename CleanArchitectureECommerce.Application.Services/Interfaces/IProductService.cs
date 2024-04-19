using CleanArchitectureECommerce.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitectureECommerce.Application.Services
{
    /// <summary>
    /// Interface for managing product-related operations.
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Retrieves all products from the database.
        /// </summary>
        /// <returns>A list of all products.</returns>
        Task<IEnumerable<Product>> GetAllProductsAsync();

        /// <summary>
        /// Retrieves a product by its ID from the database.
        /// </summary>
        /// <param name="productId">The ID of the product to retrieve.</param>
        /// <returns>The product with the specified ID.</returns>
        Task<Product> GetProductByIdAsync(int productId);

        /// <summary>
        /// Adds a new product to the database.
        /// </summary>
        /// <param name="product">The product to add.</param>
        /// <returns>True if the product was added successfully, otherwise false.</returns>
        Task<bool> AddProductAsync(Product product);

        /// <summary>
        /// Updates an existing product in the database.
        /// </summary>
        /// <param name="product">The product with updated information.</param>
        /// <returns>True if the product was updated successfully, otherwise false.</returns>
        Task<bool> UpdateProductAsync(Product product);

        /// <summary>
        /// Deletes a product from the database.
        /// </summary>
        /// <param name="productId">The ID of the product to delete.</param>
        /// <returns>True if the product was deleted successfully, otherwise false.</returns>
        Task<bool> DeleteProductAsync(int productId);
    }
}
