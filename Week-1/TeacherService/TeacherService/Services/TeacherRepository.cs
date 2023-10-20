using TeacherService.Model;

namespace TeacherService.Services
{
    public class TeacherRepository : List<Teacher>, ITeacherRepository
    {
        private readonly static List<Teacher> _teachers = TeacherSeed();

        private static List<Teacher> TeacherSeed()
        {
            var result = new List<Teacher>()
            {
                new Teacher
                {
                    Id = 1,
                    Name = "Jose",
                    School = "IPN"
                },
                new Teacher
                {
                    Id = 2,
                    Name = "Luis",
                    School = "ESCOM"
                }
            };

            return result;
        }

        public Teacher Get(int id)
        {
            return _teachers[id];
        }

        public List<Teacher> GetAll()
        {
            return _teachers;
        }
    }
}