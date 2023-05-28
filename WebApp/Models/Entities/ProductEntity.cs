using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Models.Dtos;

namespace WebApp.Models.Entities;

public class ProductEntity
{
    [Key]

    public int Id { get; set; }

    
    public string ArticleNumber { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? ImageUrl { get; set; }
    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    public string? Description { get; set; } 

    public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();

    public static implicit operator Product(ProductEntity entity)
    {
        return new Product
        {
            
            ArticleNumber = entity.ArticleNumber,
            Name = entity.Name,
            ImageUrl = entity.ImageUrl,
            Price = entity.Price,
            Description = entity.Description
        };
    }
}
