using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToArray();
        }
    }
}
