﻿using System.Reflection.Metadata.Ecma335;
using WebApp.Helpers.Repositories;
using WebApp.Models.Dtos;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Services;

public class ProductService
{
    private readonly ProductRepository _productRepo;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public ProductService(ProductRepository productRepo, IWebHostEnvironment webHostEnvironment)
    {
        _productRepo = productRepo;
        _webHostEnvironment = webHostEnvironment;
    }


    public async Task<Product>CreateAsync(ProductEntity entity)
    {
        var _entity = await _productRepo.GetAsync(x => x.ArticleNumber == entity.ArticleNumber);
        if (_entity == null)
        {
            _entity = await _productRepo.AddAsync(entity);
            if (_entity == null)
                return _entity!;
        }
        return null!;
    }

    public async Task<bool> UploadImageAsync(Product product, IFormFile image)
    {
        try
        {
            string imagePath = $"{_webHostEnvironment.WebRootPath}images/products/{product.ImageUrl}";
            await image.CopyToAsync(new FileStream(imagePath, FileMode.Create));
            return true;
        }
        catch { return false; }
    }


    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var items = await _productRepo.GetAllAsync();
        var list = new List<Product>(); 
        foreach (var item in items) 
            list.Add(item);

        return list;
    }
    
}
