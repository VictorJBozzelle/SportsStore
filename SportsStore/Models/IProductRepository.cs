using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
