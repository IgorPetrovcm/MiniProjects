using CreateTable_using_csvFile.Service;
using CsvReader;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICreateTable,CreateTable>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}");

app.Run();