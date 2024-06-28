using Scarpe_Co.Entities;
using Scarpe_Co.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Scarpe_Co.Models;
using System.Diagnostics;

namespace Scarpe_Co.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }

        public IActionResult Details(int id)
        {
            var product = _productService.GetProductById(id);    
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public IActionResult Create()
        {
            return View(new ProductViewModel());
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel model)
        {
            _productService.Add(new Prodotto
            {
                Nome = model.Nome,
                Descrizione = model.Descrizione,
                Prezzo = model.Prezzo,
                Immagine = model.Immagine,
                Immagine1 = model.Immagine1,
                Immagine2 = model.Immagine2
            });
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductViewModel
            {
                Nome = product.Nome,
                Descrizione = product.Descrizione,
                Prezzo = product.Prezzo,
                Immagine = product.Immagine,
                Immagine1 = product.Immagine1,
                Immagine2 = product.Immagine2
            });
        }


        [HttpPost]
        public IActionResult Edit(ProductViewModel model) {
            var product = _productService.GetProductById(model.Id);
            if (product == null)
            {
                return NotFound();
            }
            product.Nome = model.Nome;
            product.Descrizione = model.Descrizione;
            product.Prezzo = model.Prezzo;
            product.Immagine = model.Immagine;
            product.Immagine1 = model.Immagine1;
            product.Immagine2 = model.Immagine2;
            _productService.Update(product);
            return RedirectToAction("Index");
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
