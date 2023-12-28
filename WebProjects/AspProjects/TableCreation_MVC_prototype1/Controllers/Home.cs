namespace TableCreation;
using Microsoft.AspNetCore.Mvc;


public class Home : Controller
{
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(string[] value)
    {
        ViewBag.Message = value;

        return View();
    }
}