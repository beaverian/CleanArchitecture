using CleanArchitectureECommerce.Core.Entities;
using MediatR;


namespace CleanArchitecture.Application.Products.Queries
{
    /// <summary>
    /// Represents a query to retrieve all products.
    /// </summary>
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
