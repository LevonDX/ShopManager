using Microsoft.AspNetCore.Mvc;
using ShopManager.Data.Abstract;
using ShopManager.Data.Entities;

namespace ShopManager.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = _productRepository.GetAllProductsAsync().ToList();

            return View(products);
        }


        [HttpGet]
        public IActionResult Add()
        {
            Product product = new Product();
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.AddProductAsync(product);

                TempData["Message"] = "Product added successfully";

                return RedirectToAction(nameof(Index));
            }

            TempData["Message"] = "Invalid data";

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Product? p = await _productRepository.GetProductByIdAsync(id); 

            if (p == null)
            {
                return NotFound("Product not found");
            }

            return View(p);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.UpdateProductAsync(product);

                TempData["Message"] = "Product updated successfully";

                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _productRepository.DeleteProductAsync(id);

            TempData["Message"] = "Product deleted successfully";

            return RedirectToAction(nameof(Index));
        }
    }
}
