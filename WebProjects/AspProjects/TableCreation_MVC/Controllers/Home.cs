namespace TableCreation_MVC;
using Microsoft.AspNetCore.Mvc;


public class Home : Controller
{
    public IActionResult YourTable() => View();

    public IActionResult CreateRow() => View();
}