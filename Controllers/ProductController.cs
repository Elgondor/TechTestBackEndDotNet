using Microsoft.AspNetCore.Mvc;
using QandA.Data;
using QandA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QandA.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        IProductRepository productRepo;
        public ProductController(IProductRepository prodRepo)
        {
            productRepo = prodRepo;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts(string search)
        {
            return productRepo.GetProducts();
        }

        [HttpGet("{productId}")]
        public ActionResult<Product> GetProduct(int productId)
        {
            Product product = productRepo.GetProduct(productId);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpGet("getWhereOne/{nameProduct}")]
        public ActionResult<Product> GetWhereOne(string nameProduct)
        {
            Product product = productRepo.GetProductWithWhere(nameProduct);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            Product savedProduct = productRepo.AddProduct(product);

            return CreatedAtAction(nameof(GetProduct), new { ProductId = savedProduct.ProductId }, savedProduct);
        }

        [HttpDelete("{productId}")]
        public ActionResult<Product> PostProduct(int productId)
        {
            Product product = productRepo.GetProduct(productId);
            if (product == null)
            {
                return NotFound();
            }

            productRepo.DeleteProduct(product);

            return NoContent();
        }

        [HttpPut]
        public ActionResult<Product> UpdateProduct(Product product) {
            Product productUpdated = productRepo.UpdateProduct(product);

            return productUpdated;
        }




    }
}
