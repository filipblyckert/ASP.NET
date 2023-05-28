using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;
using WebApp.Models.Identity;

namespace WebApp.Models.Contexts;

//insett misstaget, hinner inte åtgärda
public class IdentityContext : IdentityDbContext<AppUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    {
    }
    public DbSet<AddressEntity> AspNetAddresses { get; set; }
    public DbSet<UserAddressEntity> AspNetUsersAddresses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        var roleId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid().ToString();
        

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = roleId,
               Name = "System Administrator",
               NormalizedName = "SYSTEM ADMINISTRATOR"
            }
            );
        var passwordHasher = new PasswordHasher<AppUser>();
        builder.Entity<AppUser>().HasData(new AppUser
        {
           
            FirstName = "",
            LastName = "",
            UserName = "administrator",
            Email = "administrator@domain.com",
            PasswordHash = passwordHasher.HashPassword(null!,"BytMig123"),
        });

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = roleId,
            UserId = userId,
        });
    }
}
