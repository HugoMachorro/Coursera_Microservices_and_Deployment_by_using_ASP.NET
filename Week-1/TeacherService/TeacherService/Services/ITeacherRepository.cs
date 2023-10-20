using TeacherService.Model;

namespace TeacherService.Services
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAll();
        Teacher Get(int id);
    }
}
