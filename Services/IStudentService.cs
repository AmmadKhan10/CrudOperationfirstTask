using CrudOperationFirstTask.Models;
namespace CrudOperationFirstTask.Services
{
    public interface IStudentService
    {
        Task<int> AddNewStudent(Student student);
        Task<int> UpdateNewStudent(Student student);
        Task<int> DeleteStudent(int Id);
        Task<Student> GetStudentById(int Id);
        Task<List<Student>> GetAllStudents();
    }
}
