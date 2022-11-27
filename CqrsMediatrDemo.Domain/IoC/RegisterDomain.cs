using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsMediatrDemo.Domain.IoC
{
    public static class RegisterDomain
    {
        public static void AddDomain(this IServiceCollection services)
        {
            services.AddSingleton<FakeDataStore>();
        }
    }
}
