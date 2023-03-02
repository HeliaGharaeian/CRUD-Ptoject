using LanguageInstitute.Dtos;

namespace LanguageInstitute.Services
{
    public interface ITeacherService
    {
        int Add(TeacherDto teacher);
        int Delete(int Id);
        TeacherDto Find(int Id);
        List<TeacherDto> List();
        TeacherDto Edit(TeacherDto teacher);
        List<TeacherDto> Search(string Name);
    }
}
