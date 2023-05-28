using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;

namespace WebApp.Models.Contexts;

//insett misstaget, hinner inte åtgärda
public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<ProductTagEntity> ProductTags { get; set; }

    public DbSet<ContactFormEntity> ContactForms { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

       builder.Entity<TagEntity>().HasData(
           new TagEntity { Id = 1, TagName = "new"}, 
           new TagEntity { Id = 2, TagName = "featured"},
           new TagEntity { Id = 3, TagName = "popular"}
           
      );
        builder.Entity<ProductEntity>().HasData(
            new ProductEntity { Id = 1, Name = "Product 1", Price = 300, ImageUrl = "", Description ="very good very nice"}
        );

        builder.Entity<ProductTagEntity>().HasData(

            new ProductTagEntity { ProductId = 1, TagId = 1}
            
        );
    }
}
