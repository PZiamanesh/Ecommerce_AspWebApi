using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
