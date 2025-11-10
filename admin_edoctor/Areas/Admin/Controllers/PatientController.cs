using admin_edoctor.Models;
using Microsoft.AspNetCore.Mvc;

namespace admin_edoctor.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PatientController : Controller
    {
        private EdoctorContext _context;
        // GET: PatientController
        public PatientController(EdoctorContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            //LinQ
            List<Patient> patients = _context.Patients.ToList();
            //Passing data to views
            return View(patients);
        }

        public ActionResult Delete(int id)
        {
            Patient patient = _context.Patients.FirstOrDefault(x => x.Id == id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
            }
            
            List<Patient> patients = _context.Patients.ToList();

            return View("Index", patients);
        }
    }
}
