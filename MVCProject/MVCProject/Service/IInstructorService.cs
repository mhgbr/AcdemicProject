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
        List<Instructor> GetAllInstById(int id);
        int Update(Instructor newins);

    }
}