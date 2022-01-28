using MVCProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCProject.Service
{
    public class InstructorService : IInstructorService
    {
        DBFile Context;
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

        public List<Instructor> getAllById(int id)
        {
            return Context.instrcutors.Where(s => s.Id == id).ToList();
        }
        public Instructor GetByName(string name)
        {
            return Context.instrcutors.FirstOrDefault(x => x.Name == name);
        }
        //public List<Instructor> GetStINTrk()
        //{
        //    return Context.instrcutors.Include(w => w.Student).Include(
        //        w => w.Track).ToList();
        //    )
        //}
        public int Create(Instructor ins)
        {
            Context.instrcutors.Add(ins);
            int raw = Context.SaveChanges();
            return raw;
        }

        public int Update(int id, Instructor ins)
        {
            Instructor old = Context.instrcutors.FirstOrDefault(x => x.Id == id);
            old.Name = ins.Name;
            old.Address = ins.Address;
            old.Age = ins.Age;
            old.Salary = ins.Salary;
            old.PhoneNumber = ins.PhoneNumber;
            old.Email = ins.Email;
            old.Password = ins.Password;
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

        public int Update(Track newIns)
        {
            throw new System.NotImplementedException();
        }

        public int Update(int id, Track newIns)
        {
            throw new System.NotImplementedException();
        }

        public List<Instructor> GetAllById(int id)
        {
            throw new System.NotImplementedException();
        }

        void IInstructorService.Update(int id, Instructor newins)
        {
            throw new System.NotImplementedException();
        }
    }
}
