using data_access;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Student_Management.Controllers
{
    public class StudentsController : Controller
    {
        StudentDbContext context;

        public StudentsController()
        {
            context = new StudentDbContext();
        }

        public IActionResult Index()
        {
            var groupsWithStudents = context.Groups.Include(g => g.Students).ToList();

            return View(groupsWithStudents);
        }
        public IActionResult GroupDetails(int id)
        {

            var group = context.Groups.Include(g => g.Students).FirstOrDefault(g => g.Id == id);

            if (group == null) { return NotFound(); }

            return View(group);
        }
    }
}
