using System;
using MediatR;

namespace CleanArchitecture.Application.Products.Commands
{
    public class AddProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}


