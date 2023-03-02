using LanguageInstitute.Dtos;
using LanguageInstitute.Models;
using LanguageInstitute.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LanguageInstitute.Pages.StudentCRUD
{
    public class CreateStudentModel : PageModel
    {
        private readonly IStudentService _studentService;

        public CreateStudentModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty]
        public StudentDto Students { get; set; } = new StudentDto();

        public List<Student> students { get; set; }

        [BindProperty]
        public int ClassId { get; set; }

        public List<SelectListItem> Options { get; set; }

        public void OnGet()
        {
            Options = new List<SelectListItem>
        {
            new SelectListItem { Value = "2", Text = "2" },
            new SelectListItem { Value = "3", Text = "3" }
        };


        }

        public void OnPost()
        {
            _studentService.Add(Students);
        }
    }
}
