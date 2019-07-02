using System;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Eventures.Data.SeedDatabase
{
    public class RoleSeeder : ISeeder
    {
        public RoleSeeder()
        {
        }

        public async Task SeedAsync(IApplicationBuilder app)
        {
            //var roleManager = (RoleManager<EventuresRole>)app.ApplicationServices.GetService(typeof(RoleManager<EventuresRole>));
            using (var context = (EventuresDbContext)app.ApplicationServices.CreateScope().ServiceProvider.GetService(typeof(EventuresDbContext)))
            {
                if (context.Roles.Any(x => x.Name == "Admin") == false
               && context.Roles.Any(x => x.Name == "User") == false)
                {
                    await context.Roles.AddAsync(new EventuresRole { Name = "Admin", NormalizedName = "Admin".ToUpper() });
                    await context.Roles.AddAsync(new EventuresRole { Name = "User", NormalizedName = "User".ToUpper() });
                }
                context.SaveChanges();
            }
        }
    }
}