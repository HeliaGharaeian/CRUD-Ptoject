using LanguageInstitute.Models;

namespace LanguageInstitute.Dtos
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Class> Classes { get; set; }
        public int ClassID { get; set; }


    }
}
