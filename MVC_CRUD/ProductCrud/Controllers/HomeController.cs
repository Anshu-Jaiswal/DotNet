using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductCrud.Models;
using DAL;
using BOL;
using System.Xml.Schema;
using Org.BouncyCastle.Security;

namespace ProductCrud.Controllers;

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
    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id,string nm,string dsg,string cmp,double sal,string un,string pass)
    {
        // Employee emp = new Employee{id=id,nameof = nm,designation=dsg,company=cmp,salary=sal,username=un,password=pass};
         Employee emp = new Employee(id,nm,dsg,cmp,sal,un,pass);
         DBManager.insert(emp);
         return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
