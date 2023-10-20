using StudentService.Models;

namespace StudentService.Services
{
    public class StudentRepository : List<Student>, IStudentRepository
    {
        private readonly static List<Student> _students = StudentSeed();

        private static List<Student> StudentSeed()
        {
            var result = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Hugo",
                    School = "ESCOM"
                },
                new Student
                {
                    Id = 2,
                    Name = "Andres",
                    School = "IPN"
                }
            };

            return result;
        }

        public Student Get(int id)
        {
            return _students[id];
        }

        public List<Student> GetAll()
        {
            return _students;
        }
    }
}
