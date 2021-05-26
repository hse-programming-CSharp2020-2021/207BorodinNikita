using System.Collections.Generic;
using WebApplicationMVC.Models;
using WebApplicationMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;

namespace WebApplicationMVC.Controllers
{
    public class ProductsController : Controller
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IActionResult Index()
        {
            return View(ProductService.GetProducts());
        }

        [Route("product/{id}")]
        public IActionResult Product(string id)
        {
            return View("ViewItem", ProductService.GetProducts().First(x => x.Id == id));
        }

        public IActionResult Privacy()
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