using System;
using CleanArchitectureECommerce.Application.Dto;
using MediatR;

namespace CleanArchitectureECommerce.Application.Products.Queries
{
	public class GetProductByIdQuery : IRequest<ProductDto> 
    {
        public int Id { get; set; }
    }
}

