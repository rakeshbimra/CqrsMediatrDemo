using CqrsMediatrDemo.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsMediatrDemo.Commands
{
    public record AddProductCommand(Product Product) : IRequest;
}
