using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NikAmozBooklet.AAA.Models
{
    public class AAADbContext : IdentityDbContext<CustomUserIdentity>
    {
        public AAADbContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
