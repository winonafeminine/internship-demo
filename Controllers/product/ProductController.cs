using Microsoft.AspNetCore.Mvc;
using internship_api.Models.product;

namespace internship_api.Controllers.product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // get all products
        public IEnumerable<Product> Get()
        {
            IEnumerable<Product> products = new List<Product>(){
                new Product{
                    ProductName="Barsoap",
                    ProductDescription="Feminine Barsoap"
                },
                new Product{
                    ProductName="Spray",
                    ProductDescription="Feminine Spray"
                },
            };

            return products;
        }


        // get a product by name

        [Route("{name}")]
        [HttpGet]
        public Product? Get([FromRoute] string? name)
        {
            IEnumerable<Product> products = new List<Product>(){
                new Product{
                    ProductName="Barsoap",
                    ProductDescription="Feminine Barsoap"
                },
                new Product{
                    ProductName="Spray",
                    ProductDescription="Feminine Spray"
                },
            };


            Product? product = products.Where(p => p.ProductName == name).FirstOrDefault();

            return product;
        }
    }
}