using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;
using Novel;
namespace MyFirstWebApp.Controllers;

public class BooksController : Controller
{
    private readonly ILogger<BooksController> _logger;

    public BooksController(ILogger<BooksController> logger)
    {
        _logger = logger;
    }

    
public IActionResult Index()
    {
        Books b1= new Books();
        b1.title="Collen Hover";
        b1.description="Non-Fictional";
        b1.price=250;
        b1.quantity=10;
        b1.imageurl="../images/n1.png";
  
        ViewData["books"]=b1;
        return View();
    }
    
 
    



}
