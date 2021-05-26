using QandA.Context;
using QandA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QandA.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceContext productContext;
        public ProductRepository(ECommerceContext context)
        {
            productContext = context;
        }

        public Product AddProduct(Product product)
        {
            productContext.Add(product);
            productContext.SaveChanges();
            return productContext.Products.First(x => x.ProductId == product.ProductId);
        }

        public void DeleteProduct(Product product)
        {
            productContext.Products.Remove(product);
            productContext.SaveChanges();
        }

        public IList<Product> GetProducts()
        {
            return productContext.Products.ToList();
        }

        public Product GetProduct(int productId)
        {
            return productContext.Products.FirstOrDefault(x => x.ProductId == productId);
        }

        public Product GetProductWithWhere(string nameProduct)
        {
            return productContext.Products.Where(x => x.ProductName == nameProduct).FirstOrDefault();
        }

        public Product UpdateProduct(Product productChanges)
        {
            Product product = productContext.Products.SingleOrDefault(x => x.ProductId == productChanges.ProductId);
            product.ProductName = productChanges.ProductName;
            product.ProductDescription = productChanges.ProductDescription;
            productContext.SaveChanges();
            return product;
        }
    }
}
