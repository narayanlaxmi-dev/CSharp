using E_commerce_exercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_exercise.Controllers
{
    public class DealsController : Controller
    {
        public IActionResult Index()
        {
            IList<DateOnly> date = new List<DateOnly>();
            date.Add(new DateOnly(2025, 6, 13));
            date.Add(new DateOnly(2025, 7, 15));
            date.Add(new DateOnly(2025, 8, 1));

            ViewData["date"] = date;


            IList<string> promotionalMessage = new List<string>();
            promotionalMessage.Add("Hurry ! Limited Time Offers!");
            ViewBag.PromotionalMessage = promotionalMessage;

            IList<Deal> deals = new List<Deal>();
            deals.Add(new Deal
            {
                Id = 1,
                ProductName = "Laptop",
                Discount = 50.5,
                isActive = true
            });
            deals.Add(new Deal
            {
                Id = 2,
                ProductName = "AppleMobile",
                Discount = 10.5,
                isActive = true
            });
            deals.Add(new Deal
            {
                Id = 3,
                ProductName = "Shirt",
                Discount = 70.5,
                isActive = false
            });
            deals.Add(new Deal
            {
                Id = 4,
                ProductName = "Bike",
                Discount = 5.5,
                isActive = true
            });
            return View(deals);
        }
    }
}
