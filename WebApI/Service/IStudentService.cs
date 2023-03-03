using WebApI.Model;

namespace WebApI.Service
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetAllStudents();
        public Student GetStudentById(int id);
        public int AddStudent(Student student);
        public int UpdateStudent(Student student);
        public int DeleteStudent(int id);
    }
}
