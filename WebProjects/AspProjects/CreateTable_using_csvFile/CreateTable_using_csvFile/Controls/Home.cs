namespace CreateTable_using_csvFile.Controls;

using CreateTable_using_csvFile.Service;
using Microsoft.AspNetCore.Mvc;
using CsvReader;


public class Home : Controller
{
    private ICreateTable createTable;

    public Home(ICreateTable createTable)
    {
        this.createTable = createTable;
    }
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(IFormFile file)
    {
        if (!new[] {".csv"}.Any(ext => file.FileName.Contains(ext))) 
            return BadRequest("Your file extension not correct");

        CsvGeneral csv = createTable.GetCsvTable(file);

        ViewBag.Message = csv;

        return View("~/Views/Home/Table.cshtml");
    }


}