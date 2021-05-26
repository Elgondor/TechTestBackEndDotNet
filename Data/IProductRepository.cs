using QandA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QandA.Data
{
    public interface IProductRepository
    {
        IList<Product> GetProducts();
        Product GetProduct(int productId);

        Product GetProductWithWhere(string nameProduct);
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
