using MVCProject.Models;
using System.Collections.Generic;

namespace MVCProject.Service
{
    public interface IInstructorService
    {
        int Create(Instructor newIns);
        int Delete(int id);
        List<Instructor> GetAll();
        Instructor GetById(int id);
        Instructor GetByName(string name);
        int Update(int id, Track newIns);
        List<Instructor> GetAllById(int id);
        void Update(int id, Instructor newins);
    }
}