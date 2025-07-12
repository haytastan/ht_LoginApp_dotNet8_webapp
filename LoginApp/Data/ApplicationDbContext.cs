using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LoginApp.Models;

namespace LoginApp.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // Customize the ASP.NET Identity model here
        // For example, you can rename the ASP.NET Identity table names
        
        // builder.Entity<ApplicationUser>().ToTable("Users");
        // builder.Entity<IdentityRole>().ToTable("Roles");
        // builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        // builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        // builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        // builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        // builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
    }
}