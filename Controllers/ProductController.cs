using DBFirstProje.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstProje.Web.Controllers
{
    public class ProductController : Controller
    {

        //fields  _ ile başlar.
        private AppDbContext _context;
        private readonly ProductRepository _productRepository;

        public ProductController(AppDbContext context)
        {
            _context = context;
            _productRepository = new ProductRepository();//
                                                         //id VTYS tarafından otomatik olarak verilecektir.
                                                         //  _context.Products.Add(new Product() { Name="Bilgisayar",Price=23000,Stock=10});
            if (!_context.Products.Any()) //eğer veri varsa ekleme.
            {
                _context.Products.Add(new() { Name = "Bilgisayar", Price = 23000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "Monitör", Price = 20000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "Laptop", Price = 43000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "Hoparlör", Price = 25000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "Kamera", Price = 55000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "Masa", Price = 30000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "SSD Disk", Price = 8000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "Kasa", Price = 5000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "Ekran Kartı", Price = 35000, Stock = 10, ImageUrl = "images/foto.jpeg" });
                _context.Products.Add(new() { Name = "Tablet", Price = 6000, Stock = 10, ImageUrl = "images/foto.jpeg" });
            }
            //önemli
            _context.SaveChanges();
        }
        public IActionResult Index()
        {
            var products = _context.Products;

            return View(products);
        }

        public IActionResult Remove(int id)
        {
            var product=_context.Remove(_context.Products.FirstOrDefault(x=>x.Id== id));
            _context.SaveChanges();
            return RedirectToAction("Index");
            //return RedirectToAction("Index","Product");
            
        }

        [HttpGet]
        public IActionResult Add() //Boş ekleme sayfası için gerekli
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product) //Ürün kaydetme için gerekli.
        {
            _context.Products.Add(product);
            _context.SaveChanges(); //veritabanında işlenmesi için. Silme,güncelleme ve ekleme işlemlerinde unutma!!!
            return View();
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var product=_context.Products.FirstOrDefault(x=>x.Id == id);    
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
            //return RedirectToAction("Index","Product");
        }
        public IActionResult Details(int id)
        {
            var urun = _context.Products.FirstOrDefault(x => x.Id == id);
            return View(urun);
        }
    }
}
