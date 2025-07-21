namespace DependencyInjection.Models
{
    public class Teacher:ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher() {
            FirstName = "Musa";
            LastName = "Aydın";
        }
        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
