using WebApplication3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        // Display Product Catalog
        public ActionResult Index()
        {
            List<Product> products = GetProducts();
            return View(products);
        }

        // Display Product Details
        public ActionResult Details(int id)
        {
            List<Product> products = GetProducts();

            Product product = products.FirstOrDefault(
                p => p.ProductId == id
            );

            return View(product);
        }

        // Get Product List
        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Description = "Dell Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile",
                    Description = "Samsung Mobile",
                    Price = 20000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphone",
                    Description = "Wireless Headphone",
                    Price = 2500,
                    Category = "Accessories"
                }
            };
        }
    }
}