namespace CreateTable_using_csvFile.Controls;
using Microsoft.AspNetCore.Mvc;


public class Home : Controller
{
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(IFormFile file)
    {
        return RedirectToAction("Table", "Home", new { File = file });
    }

    public IActionResult Table(IFormFile File)
    {
        return View();
    }
}