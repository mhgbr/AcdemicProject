using MVCProject.Models;
using System;
using System.Collections.Generic;

namespace Day1.Services
{
    public interface IStudentRepository
    {
        Guid id { get; set; }

        int Create(Student std);
        int Delete(int id);
        List<Student> getAll();
        Student getById(int id);
        Student getByName(string Name);
        List<Student> getStudentByTrackId(int TRACKId);
        int Update(int id, Student std);
    }
}