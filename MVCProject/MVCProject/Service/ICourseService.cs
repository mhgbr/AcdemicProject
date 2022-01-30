using MVCProject.Models;
using System.Collections.Generic;

namespace MVCProject.Service
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        Course GetByName(string name);
        int Create(Course course);
        int Update(Course Newcrs);
        public int Delete(int id);

    }
}
