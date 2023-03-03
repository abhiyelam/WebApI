using WebApI.Data;
using WebApI.Model;

namespace WebApI.Repository
{
    public class StudentRepository:IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db) 
        {
            this.db = db;
        }

        public int AddStudent(Student student)
        {
            db.Students.Add(student);
            int result=db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var p = db.Students.Where(x => x.Id ==id).FirstOrDefault();
            if (p != null)
            {
                db.Students.Remove(p);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return db.Students.Find(id);
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;
            var p=db.Students.Where(x=>x.Id==student.Id).FirstOrDefault();
            if(p!=null)
            {
                p.Name = student.Name;
                p.Mobileno = student.Mobileno;
                p.Email = student.Email;
                p.Percentage = student.Percentage;
                result=db.SaveChanges();
            }
            return result;
        }
    }
}
