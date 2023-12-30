namespace TableCreation_MVC;
using Microsoft.AspNetCore.Mvc;
using TableCreation_MVC.Models.Validation;


public class Home : Controller
{
    public ITable table;
    public Home(ITable table)
    {
        this.table = table;
    }
    public IActionResult YourTable() => View();

    public IActionResult CreateRow() => View();

    [HttpPost]
    public IActionResult CreateRow(string[] values)
    {
        if (ValidationColumns.IsValid(values))
        {
            table.AddRow(values);
            ViewBag.Message = table;

            return View("~/Views/Home/YourTable.cshtml"); 
        }
        else {
            ViewBag.Message = @"<script> alert('Error input data') </script>";
            return View();
        }
    }
}