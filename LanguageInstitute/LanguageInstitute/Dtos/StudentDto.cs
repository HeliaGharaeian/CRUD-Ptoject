namespace LanguageInstitute.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        //public IEnumerable<Class> Classes { get; set; }
        public ClassDto Class { get; set; }
        public int ClassId { get; set; }
    }
}
