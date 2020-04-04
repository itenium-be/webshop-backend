using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webshop.DataAccess;
using Webshop.Entities;

namespace Webshop.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebshopContext _context;
        public ProductRepository(WebshopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var result = await _context.Products.ToArrayAsync();
            return result;
        }
    }
}
