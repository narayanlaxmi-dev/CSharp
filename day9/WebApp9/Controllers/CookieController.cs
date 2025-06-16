using Microsoft.AspNetCore.Mvc;

namespace WebApp9.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult SetCookie()
        {
            Response.Cookies.Append("UserName", "Narayan" ?? "Guest", new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddDays(1),
                HttpOnly = true
            });

            return Content("Cookie Set!");
        }

        public IActionResult GetCookie()
        {
            var userName = Request.Cookies["UserName"];
            return Content($"UserName from Cookie: {userName}");
        }

        public IActionResult DeleteCookie()
        {
            Response.Cookies.Delete("UserName");
            return Content("Cookie Deleted!");
        }
    }
}
