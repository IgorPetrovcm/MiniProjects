# Передать массив значений из form в контроллер

Главное иметь в `form` **инпуты** с одинаковым `name` например:
```html
<form method="post">
    <input name="values"/>
    <input name="values"/>
    <input name="values"/>
    <input name="values"/>
</form>
``` 
Контроллер же должен принять массив этих строк, поэтому параметром `action` будет `string[] values`, то есть иметь такое же имя как и `name` **инпутов**:
```csharp
[HttpPost]
public IActionResult Index(string[] values)
{
    ViewBag.Message = value;

    return View();
}
```