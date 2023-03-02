using LanguageInstitute.Dtos;
using LanguageInstitute.Models;
using System.Security.Claims;

namespace LanguageInstitute.Services
{
    public interface IClassService
    {
        int Add(ClassDto Class);
        int Delete(int Id);
        ClassDto Find(int Id);
        List<ClassDto> List();
        ClassDto Edit(ClassDto Class);
    }
}
