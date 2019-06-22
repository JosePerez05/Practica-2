using Persistence;

namespace Services
{
    public interface IStudentService {
        IEnumerable<Student> GetAll(Student model);
        bool Add(StudentServices model);
        boll Delete(int id);
        boll Update(StudentServices model);
        Student Get(int id);


    }
    public class StudentServices: IStudentService
    {
        private readonly StudentDbContext _studenteDbContext;
        public StudentServices(StudentDbContext _studentDbContext)
        {
            _studentDbContext = studentDbContext; 
        }

        public Student Get(int id)
        {
            var result = new Student();
            try
            {
                result = _studenteDbContext.Student.Single(x => x.StudentId == id); 
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public IEnumerable<Student> GetAll(Student model)
        {
            var result = new List<Student>();
            try
            {
                result = _studenteDbContext.Student.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }
        public bool Add(StudentServices model)
        {
            try
            {
                _studenteDbContext.Add(model);
                _studenteDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
        public bool Update(StudentServices model)
        {
            try
            {
                var originalModel = _studenteDbContext.Student.Single(x => x.StudentID == model.StudentId);

                originalModel.Name = model.Name;
                originalModel.LastName = model.LastName;
                originalModel.Bio = model.bio;
                _studenteDbContext.Update(model);
                _studenteDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
        public bool Delete(int id)
        {
            try
            {
                _studenteDbContext.Entry(new Student { StudentId=id}).Stage=EntityStage.Deleted; 
                _studenteDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
    }
}
