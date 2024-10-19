using DependencyInjection.Services;

namespace DependencyInjection.Managers
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"Teacher: {FirstName} {LastName}";
        }
    }
}
