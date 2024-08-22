using Catalog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Core.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
