using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FlowerWeb.Models;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using EmpeEmp;

namespace FlowerWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult login()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
    public IActionResult postregister(string Firstname,string Lastname,string Email,string Contact,string Password){
        Employee emp=new Employee(Firstname,Lastname,Email,Contact,Password);
         var options=new JsonSerializerOptions {IncludeFields=true};
         var myjson=JsonSerializer.Serialize<Employee>(emp,options);

        string path=@"D:\Sahil Ansari DotNet\DotNet-Practice\Day8\FlowerWeb\empinfo.json";
        //serialize all the worklist in the json file
        System.IO.File.AppendAllText(path,myjson);
        return View();     
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
