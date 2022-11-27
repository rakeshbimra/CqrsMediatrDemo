using CqrsMediatrDemo.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsMediatrDemo.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
