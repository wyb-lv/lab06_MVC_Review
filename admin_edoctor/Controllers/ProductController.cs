using admin_edoctor.Models;
using Microsoft.AspNetCore.Mvc;

namespace admin_edoctor.Controllers
{
    public class ProductController : Controller
    {
        private EdoctorContext context;

        public ProductController(EdoctorContext context)
        {
            this.context = context;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ViewAll()
        {
            List<Product> products = context.Products.OrderByDescending(x => x.Price)
                .ToList();
            
            return View(products);
        }
        
        public ActionResult Details(int id)
        {
            Product product = context.Products.FirstOrDefault(x => x.ProductId == id);
            if (product == null){}
            return View(product);
            
        }

    }
}
