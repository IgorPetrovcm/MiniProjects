namespace InteractiveTableCreation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

public class Home : Controller
{
    public IActionResult Index() => View();

    public IActionResult CreateRow()
    {
        return View();
    }
}