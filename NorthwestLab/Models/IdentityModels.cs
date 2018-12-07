using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace NorthwestLab.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base()
        {

        }
        public ApplicationRole(string roleName) : base(roleName)
        {

        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<NorthwestLab.Models.WorkOrders> WorkOrders { get; set; }

        public System.Data.Entity.DbSet<NorthwestLab.Models.Customers> Customers { get; set; }

        public System.Data.Entity.DbSet<NorthwestLab.Models.TestTimeLog> TestTimeLogs { get; set; }

        public System.Data.Entity.DbSet<NorthwestLab.Models.Employees> Employees { get; set; }

        public System.Data.Entity.DbSet<NorthwestLab.Models.Tests> Tests { get; set; }

        public System.Data.Entity.DbSet<NorthwestLab.Models.CompoundReceipts> CompoundReceipts { get; set; }

        public System.Data.Entity.DbSet<NorthwestLab.Models.Samples> Samples { get; set; }

        public System.Data.Entity.DbSet<NorthwestLab.Models.Assays> Assays { get; set; }

        public System.Data.Entity.DbSet<NorthwestLab.Models.Compounds> Compounds { get; set; }
    }
}