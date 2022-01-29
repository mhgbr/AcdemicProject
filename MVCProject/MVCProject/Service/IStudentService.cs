using MVCProject.Models;
using System.Collections.Generic;

namespace MVCProject.Service
{
    public interface IStudentService
    {
        int Create(Student std);
        int Delete(int id);
        List<Student> GetAll();
        Student GetById(int id);
        Student GetByName(string Name);
        List<Student> GetStudentByTrackId(int TRACKId);
        int Update(Student std);
    }
}