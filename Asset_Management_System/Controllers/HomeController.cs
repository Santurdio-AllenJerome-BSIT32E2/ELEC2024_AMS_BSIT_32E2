using Asset_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asset_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Products()
        {
            ViewData["ActivePage"] = "Products";
            return View();
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            // Fetch the product by id and pass it to the view
            return View(new ProductModel { Id = id, Name = "Product A", Description = "Description A", Price = 100, Quantity = 10 });
        }

        [HttpPost]
        public IActionResult EditProduct(ProductModel model)
        {
            // Save the updated product
            return RedirectToAction("Products");
        }

        public IActionResult DeleteProduct(int id)
        {
            // Delete the product by id
            return RedirectToAction("Products");
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductModel model)
        {
            // Save the new product
            return RedirectToAction("Products");
        }

        public IActionResult Contacts()
        {
            ViewData["ActivePage"] = "Contacts";
            return View();
        }

        public IActionResult Tasks()
        {
            ViewData["ActivePage"] = "Tasks";
            return View();
        }

        public IActionResult Assets()
        {
            ViewData["ActivePage"] = "Assets";
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
