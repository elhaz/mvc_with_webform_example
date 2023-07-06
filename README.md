# mvc_on_webform

## Project Environment

- Visual Studio 2022
- .NET Framework 4.8.1

## Project Template

- ASP.NET WEB Application (.NET Framework)
- [x] Web Form
- [x] MVC
- [x] Web API

## How to use

```csharp
// HomeController.cs

public ActionResult Site1() {
    Server.Transfer("~/WebForm/Site1/WebForm1.aspx");
    return View();
}
```

when you access `http://localhost:xxxx/Home/Site1`, you can see `~/WebForm/Site1/WebForm1.aspx` page.
