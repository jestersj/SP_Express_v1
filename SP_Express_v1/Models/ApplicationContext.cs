using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SP_Express_v1.Models
{
    /// <summary>
    /// контекст подключения к бд
    /// </summary>
    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        /// <summary>
        /// подключение к бд
        /// </summary>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
             // Database.EnsureCreated();
        }
    }
}
