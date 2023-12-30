using TableCreation_MVC;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ITable, Table>();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute("default","{controller=Home}/{action=YourTable}");

app.Run();
