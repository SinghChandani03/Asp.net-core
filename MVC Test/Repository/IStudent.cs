using MVC_Test.Models;

namespace MVC_Test.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();

        StudentModel getStudentById(int id);
    }
}
