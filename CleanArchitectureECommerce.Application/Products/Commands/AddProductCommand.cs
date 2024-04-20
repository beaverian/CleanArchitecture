using MediatR;

namespace CleanArchitectureECommerce.Application.Products.Commands
{
    public class AddProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
