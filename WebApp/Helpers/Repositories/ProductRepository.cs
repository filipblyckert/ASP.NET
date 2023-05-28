using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApp.Models.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories
{
    public class ProductRepository : Repo<ProductEntity>
    {

        private readonly DataContext _context;
        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        //Hinner inte åtgärda innan deadline

       /* public override async Task<ProductEntity> GetAsync(Expression<Func<ProductEntity, bool>> predicate)
        {
            var products = await _context.Products.Include(x => x.ProductTags).ThenInclude(x => x.Tag).ToListAsync();
            return products;
        }*/
    }
}
