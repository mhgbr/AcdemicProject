using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCProject.Service
{
    public class StudentRepository : IStudentRepository
    {
        // Services Student Model CRUD
        DBFile context; //= new CrsEntities();

        public Guid id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public Guid id { get ; set ; }

        public StudentRepository(DBFile _context)
        {
            //id = Guid.NewGuid();
            context = _context;
        }

        //Read All
        public List<Student> getAll()
        {
            return context.Students.ToList();
        }
        //Read One
        public Student getById(int id)
        {
            return context.Students.FirstOrDefault(i => i.Id == id);
        }

        public Student getByName(string Name)
        {
            return context.Students.FirstOrDefault(i => i.Name == Name);
        }

        public List<Student> getStudentByTrackId(int TRACKId)
        {
            return context.Students.Where(w => w.TR == TRACKId).ToList();
        }
        //Create
        public int Create(Student std)
        {
            context.Students.Add(std);
            int row = context.SaveChanges();
            return row;
        }
        //Update
        public int Update(int id, Student std)
        {
            Student oldstd = context.Students.FirstOrDefault(i => i.Id == id);
            oldstd.Name = std.Name;
            oldstd.Email = std.Email;
            oldstd.Password = std.Password;
            oldstd.Address = std.Address;
            oldstd.PhoneNumber = std.PhoneNumber;
            oldstd.Age = std.Age;
            oldstd.TR = std.TR;
            oldstd.Inst = std.Inst;



            int row = context.SaveChanges();
            return row;
        }
        //Delete
        public int Delete(int id)
        {
            Student oldstd = context.Students.FirstOrDefault(i => i.Id == id);
            context.Students.Remove(oldstd);

            int row = context.SaveChanges();
            return row;
        }
    }
}
