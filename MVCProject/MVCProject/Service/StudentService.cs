using MVCProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCProject.Service
{
    public class StudentService : IStudentService
    {
        // Services Student Model CRUD
        public DBFile Context { get; } //= new CrsEntities();
        public StudentService(DBFile _context)
        {
            //id = Guid.NewGuid();
            Context = _context;
        }

        //Read All
        public List<Student> GetAll()
        {
            return Context.Students.ToList();
        }
        //Read One
        public Student GetById(int id)
        {
            return Context.Students.FirstOrDefault(i => i.Id == id);
        }

        public Student GetByName(string Name)
        {
            return Context.Students.FirstOrDefault(i => i.Name == Name);
        }

        public List<Student> GetStudentByTrackId(int TRACKId)
        {
            return Context.Students.Where(w => w.Track_Id == TRACKId).ToList();
        }
        //Create
        public int Create(Student std)
        {
            Context.Students.Add(std);
            int row = Context.SaveChanges();
            return row;
        }
        //Update
        public int Update(Student std)
        {
            Context.Update(std);
            int row = Context.SaveChanges();
            return row;
        }
        //Delete
        public int Delete(int id)
        {
            Context.Remove(Context.Students.FirstOrDefault(i => i.Id == id));
            int row = Context.SaveChanges();
            return row;
        }
    }
}
