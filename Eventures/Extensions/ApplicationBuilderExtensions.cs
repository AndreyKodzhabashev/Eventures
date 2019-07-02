using Eventures.Data;
using Microsoft.AspNetCore.Builder;
using System.Linq;
using System.Reflection;
using Eventures.Data.SeedDatabase;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Eventures.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Eventures.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder builder { get; set; }
        public static void UseSeeder(this IApplicationBuilder app)
        {
            var types = Assembly
                       .GetAssembly(typeof(EventuresDbContext))
                       .GetTypes()
                       .Where(p => typeof(ISeeder).IsAssignableFrom(p) && !p.IsInterface & p.IsClass)
                       .ToList();

            foreach (var type in types)
            {
                var inst = (ISeeder)Activator.CreateInstance(type);

                Task.Run(async () => await inst.SeedAsync(app)).GetAwaiter().GetResult();

            }

        }
    }
}
