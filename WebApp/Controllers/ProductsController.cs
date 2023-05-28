using Microsoft.AspNetCore.Mvc;
using WebApp.Helpers.Services;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers;

public class ProductsController : Controller
{
  private readonly ProductService _productService;

    public ProductsController(ProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new ProductsViewModel
        {
            Products = await _productService.GetAllAsync()
        };
        return View(viewModel);
    }

    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Add(ProductRegistrationViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var product = await _productService.CreateAsync(viewModel);
            if (product !=null)
            {
                if(viewModel.Image !=null)
                await _productService.UploadImageAsync(product, viewModel.Image);
                return RedirectToAction("Index");
            } 
                
            ModelState.AddModelError("", "Something went wrong.");
        }
        return View(viewModel);
    }
}
