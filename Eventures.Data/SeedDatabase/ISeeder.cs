using Eventures.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Eventures.Data.SeedDatabase
{
    public interface ISeeder
    {
        Task SeedAsync(IApplicationBuilder app);
    }
}
