using MVC_Test.Models;

namespace MVC_Test.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return Datasource();
        }

        public StudentModel getStudentById(int id)
        {
            return Datasource().Where(x => x.Rollno == id).FirstOrDefault();
        }
        private List<StudentModel> Datasource()
        {
            return new List<StudentModel>
            {
                new StudentModel { Rollno = 1, Name = "chandani"},
                new StudentModel { Rollno = 2, Name = "Suraj"}
            };
        }
    }
}
