using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using DAL;

namespace HRPortal.Controllers;

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
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(string Firstname, string Lastname ,string Phone, string Address,string Password){

        Company cmp = new Company(Firstname,Lastname ,Phone,Address,Password);
        Console.WriteLine(Firstname + Lastname + Phone + Address + Password +" In Controller");
        HRDBManager.Insert(cmp);
        return View();
    }
    [HttpGet]
    public IActionResult Login(){
        return View();
    }
    [HttpPost]
    public IActionResult Login(string userName, string password){
        Console.WriteLine(userName + " "+ password);
        if(userName =="Nilesh" && password=="1234"){
            return this.RedirectToAction("Welcome");
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Welcome()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
     
}
