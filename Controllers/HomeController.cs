using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _.Models;

namespace _.Controllers;

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
    public IActionResult ProductDetails(int id)
        {
            
            ViewBag.ProductId = id;
            return View();
        }
        public IActionResult Cart()
        {
            var cartItems = new List<CartItem>
            {
                new CartItem { Id = 1, Name = "Product 1", Price = 19.99, Quantity = 2 },
                new CartItem { Id = 2, Name = "Product 2", Price = 29.99, Quantity = 1 }
            };
            
            return View(cartItems);
        } 

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
     
}
