using admin_edoctor.Models;
using Microsoft.AspNetCore.Mvc;

namespace admin_edoctor.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private EdoctorContext context;

        public AdminController(EdoctorContext ctx)
        {
            context = ctx;
        }

        // GET: AdminController
        //Action
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Appoinment()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }
    
        public IActionResult Schedule()
        {
            return View();
        }
    
        public IActionResult Patient()
        {
            List<Patient> patients = context.Patients.ToList();
            return View(patients);
        }
    }
}
