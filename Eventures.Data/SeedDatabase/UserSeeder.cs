using Eventures.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Data.SeedDatabase
{
    public class UserSeeder : ISeeder
    {
        private readonly string standardPassword = "12345";

        public UserSeeder()
        { }

        public async Task SeedAsync(IApplicationBuilder app)
        {
            using (var userManager = (UserManager<EventuresUser>)app.ApplicationServices.CreateScope().ServiceProvider.GetService(typeof(UserManager<EventuresUser>)))
            {
                if (userManager.Users.Count() == 0)
                {
                    var userAdmin = new EventuresUser
                    {
                        FirstName = "Pesho",
                        LastName = "Peshev",
                        Email = "test@test.bg",
                        UCN = "1234567890",
                        UserName = "Pesho",
                    };

                    var userUser = new EventuresUser
                    {
                        FirstName = "Gosho",
                        LastName = "Goshev",
                        Email = "test@test.bg",
                        UCN = "1234567890",
                        UserName = "Gosho",
                    };

                    await userManager.CreateAsync(userAdmin, standardPassword);
                    await userManager.CreateAsync(userUser, standardPassword);
                }
            }
        }
    }
}