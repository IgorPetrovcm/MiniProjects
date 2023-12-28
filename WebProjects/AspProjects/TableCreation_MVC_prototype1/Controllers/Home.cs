namespace TableCreation;
using Microsoft.AspNetCore.Mvc;
using CsvReader;
using TableCreation.Services;


public class Home : Controller
{
    private ITable table;

    public Home(ITable table)
    {
        this.table = table;
    }
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(string[] value)
    {
        table.AddRow(value);

        ViewBag.Message = table;
        
        return View();
    }
}