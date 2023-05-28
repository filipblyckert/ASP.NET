using WebApp.Models.Dtos;

namespace WebApp.Models.ViewModels;

public class ProductsViewModel
{
    public IEnumerable<Product> Products { get; set; } = new List<Product>();   
}
