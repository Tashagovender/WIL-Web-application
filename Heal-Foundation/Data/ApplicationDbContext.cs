using Heal_Foundation.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Heal_Foundation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Volunteer> Volunteers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
