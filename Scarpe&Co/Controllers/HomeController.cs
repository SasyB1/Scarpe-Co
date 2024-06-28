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
        private readonly IWebHostEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IWebHostEnvironment env)
        {
            _logger = logger;
            _productService = productService;
            _env = env;
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
            if (ModelState.IsValid)
            {
                var product = new Prodotto
                {
                    Nome = model.Nome,
                    Descrizione = model.Descrizione,
                    Prezzo = model.Prezzo
                };

               
                if (model.Immagine != null && model.Immagine.Length > 0)
                {
                    string uploads = Path.Combine(_env.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, product.Id.ToString() + ".jpg");
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Immagine.CopyTo(fileStream);
                    }
                    product.Immagine = "/images/" + product.Id.ToString() + ".jpg";
                }
                if (model.Immagine1 != null && model.Immagine1.Length > 0)
                {
                    string uploads = Path.Combine(_env.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, product.Id.ToString() + "_img1.jpg");
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Immagine1.CopyTo(fileStream);
                    }
                    product.Immagine1 = "/images/" + product.Id.ToString() + "_img1.jpg";
                }
                if (model.Immagine2 != null && model.Immagine2.Length > 0)
                {
                    string uploads = Path.Combine(_env.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, product.Id.ToString() + "_img2.jpg");
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Immagine2.CopyTo(fileStream);
                    }
                    product.Immagine2 = "/images/" + product.Id.ToString() + "_img2.jpg";
                }
                _productService.Add(product);
                return RedirectToAction("Index");
            }
            return View(model);
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
            });
        }


        [HttpPost]
        public IActionResult Edit(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _productService.GetProductById(model.Id);
                if (product == null)
                {
                    return NotFound();
                }

                product.Nome = model.Nome;
                product.Descrizione = model.Descrizione;
                product.Prezzo = model.Prezzo;

               
                if (model.Immagine != null && model.Immagine.Length > 0)
                {
                    string uploads = Path.Combine(_env.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, product.Id.ToString() + ".jpg");
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Immagine.CopyTo(fileStream);
                    }
                    product.Immagine = "/images/" + product.Id.ToString() + ".jpg";
                }
                if (model.Immagine1 != null && model.Immagine1.Length > 0)
                {
                    string uploads = Path.Combine(_env.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, product.Id.ToString() + "_img1.jpg");
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Immagine1.CopyTo(fileStream);
                    }
                    product.Immagine1 = "/images/" + product.Id.ToString() + "_img1.jpg";
                }
                if (model.Immagine2 != null && model.Immagine2.Length > 0)
                {
                    string uploads = Path.Combine(_env.WebRootPath, "images");
                    string filePath = Path.Combine(uploads, product.Id.ToString() + "_img2.jpg");
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Immagine2.CopyTo(fileStream);
                    }
                    product.Immagine2 = "/images/" + product.Id.ToString() + "_img2.jpg";
                }
                _productService.Update(product);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
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
