using Exercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            IList<Product> products = new List<Product>();
            products.Add(new Product { productId = 1, productName = "Laptop", price = 50000 ,productCategory="Electornic"});
            products.Add(new Product { productId = 2, productName = "Mobile", price = 20000, productCategory = "Electornic" });
            products.Add(new Product { productId = 3, productName = "Shirt", price = 500, productCategory = "Clothes" });
            products.Add(new Product { productId = 4, productName = "Pen", price = 5000, productCategory = "Stationery" });


            return View(products);
        }
    }
}
