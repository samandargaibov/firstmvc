using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace FirstMVC.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id= 1,
                    Name = "Semender"
                },
                new Student
                {
                    Id= 2,
                    Name = "Kamran"
                },
                new Student
                {
                    Id= 3,
                    Name = "Ali"
                },
                new Student
                {
                    Id= 4,
                    Name = "Michael"
                },
            };
            return View(students);
        }

        public IActionResult GetJson()
        {
            var students = new
            {
                id = 1,
                name = "Semender"
            };
               return View(students);

        }

        public IActionResult Details (int? id)
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id= 1,
                    Name = "Semender"
                },
                new Student
                {
                    Id= 2,
                    Name = "Kamran"
                },
                new Student
                {
                    Id= 3,
                    Name = "Ali"
                },
                new Student
                {
                    Id= 4,
                    Name = "Michael"
                },
            };

            if (id == null)
            {
                return NotFound();
            }
            
            var student = students.FirstOrDefault(x => x.Id == id);

            if(student == null)
            {
                return NotFound();
            }

            
            return View(student);
        }
    }
}
