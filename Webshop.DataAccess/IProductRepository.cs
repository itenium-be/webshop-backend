using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Entities;

namespace Webshop.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
