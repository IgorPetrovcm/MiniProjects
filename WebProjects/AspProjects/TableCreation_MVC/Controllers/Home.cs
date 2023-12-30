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
    public IActionResult YourTable()
    {
        ViewBag.Message = table;

        return View();
    }

    public IActionResult CreateRow() => View();

    [HttpPost]
    public IActionResult CreateRow(string[] values)
    {
        if (ValidationColumns.IsValid(values))
        {
            table.AddRow(values);

            return Redirect("YourTable"); 
        }
        else {
            ViewBag.Message = @"<script> alert('Error input data') </script>";
            return View();
        }
    }
}