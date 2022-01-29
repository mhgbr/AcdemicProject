using MVCProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCProject.Service
{
    public class InstructorService : IInstructorService
    {
        public DBFile Context { get; }
        public InstructorService(DBFile context)
        {
            Context = context;
        }

        public List<Instructor> GetAll()
        {
            return Context.instrcutors.ToList();
        }

        public Instructor GetById(int id)
        {
            return Context.instrcutors.FirstOrDefault(x => x.Id == id);
        }

        public Instructor GetByName(string name)
        {
            return Context.instrcutors.FirstOrDefault(x => x.Name == name);
        }
        public List<Instructor> GetAllInstById(int id)
        {
            return Context.instrcutors.Where(s => s.Track_Id == id).ToList();
        }

        public int Create(Instructor ins)
        {
            Context.instrcutors.Add(ins);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(Instructor ins)
        {
            Context.Update(ins);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Delete(int id)
        {
            Instructor old = Context.instrcutors.FirstOrDefault(x => x.Id == id);
            Context.instrcutors.Remove(old);
            int raw = Context.SaveChanges();
            return raw;
        }
    }
}
