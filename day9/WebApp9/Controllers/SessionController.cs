using Microsoft.AspNetCore.Mvc;


// https://localhost:7299/Session/SetSession
public class SessionController : Controller
{
    [HttpGet]
    public IActionResult SetSession()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SetSession(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            ViewBag.Message = "Name cannot be empty.";
            return View();
        }

        HttpContext.Session.SetString("UserName", name);
        return RedirectToAction("GetSession");
    }

    public IActionResult GetSession()
    {
        string userName = HttpContext.Session.GetString("UserName") ?? "Session not found.";
        ViewBag.UserName = userName;

        return View();
    }

    public IActionResult ClearSession()
    {
        HttpContext.Session.Remove("UserName");
        ViewBag.Message = "Session 'UserName' has been cleared.";

        return View();
    }
}
