namespace StudentService.Services
{
    public interface IStudentRepository
    {
        List<Models.Student> GetAll();

        Models.Student Get(int id);
    }
}
