namespace WebApp.Models.Dtos;

public class Product
{
    public string ArticleNumber { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
}
