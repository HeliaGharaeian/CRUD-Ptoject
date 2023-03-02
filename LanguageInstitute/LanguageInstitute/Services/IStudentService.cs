using LanguageInstitute.Dtos;

namespace LanguageInstitute.Services
{
    public interface IStudentService
    {
        int Add(StudentDto student);
        int Delete(int Id);
        StudentDto Find(int Id);
        List<StudentDto> List();
        StudentDto Edit(StudentDto student);
        List<StudentDto> Search(string Name);
    }
}
