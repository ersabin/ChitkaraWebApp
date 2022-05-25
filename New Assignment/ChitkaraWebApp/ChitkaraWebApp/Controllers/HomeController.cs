using ChitkaraWebApp.Models;
using ChitkaraWebApp.Views.RequestController;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ChitkaraWebApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ChitkaraContext _context;
        public HomeController(ChitkaraContext value)
        {
            _context = value;
        }
        public IActionResult Index()
        {
            return View("Home");
        }

        [HttpGet]
        public JsonResult GetStudentDetails()
        {
            var getTheStudents = _context.StudentDetails.ToList();
            return Json(getTheStudents);
        }



        public async Task<JsonResult> GetStudentDetailsByIdAsync(int id)
        {
            var getTheStudent = await _context.StudentDetails.FindAsync(id);
            return Json(getTheStudent);
        }



        [HttpPost]
        public JsonResult PostStudent([FromBody]StudentDetailsRequest value)
        {
            StudentDetails S1 = new StudentDetails();
            S1.StudentName = value.StudentName;
            S1.StudentAge = value.StudentAge;
            S1.StudentContact = value.StudentContact;
            S1.StudentDepartment = value.StudentDepartment;



            _context.StudentDetails.Add(S1);
            _context.SaveChanges();
            return Json(value);
        }
    }
}
