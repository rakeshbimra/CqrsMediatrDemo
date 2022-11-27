using CqrsMediatrDemo.Domain;
using CqrsMediatrDemo.Queries.Handlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CqrsMediatrDemo.Queries.IoC
{
    public static class RegisterQueries
    {
        public static void AddQueries(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetProductsQueryHandler));
        }
    }
}
