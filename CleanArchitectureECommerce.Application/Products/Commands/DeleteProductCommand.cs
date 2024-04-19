using MediatR;

namespace CleanArchitectureECommerce.Application.Products.Commands
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
