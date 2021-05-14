using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mercy",
                    Email = "mercy@test.com",
                    UserName = "mercy@test.com",
                    Address = new Address
                    {
                        FirstName = "Bob",
                        LastName = "Mercy Titi",
                        Street = "10 The Street",
                        City = "Lagos",
                        ZipCode = "90210"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}