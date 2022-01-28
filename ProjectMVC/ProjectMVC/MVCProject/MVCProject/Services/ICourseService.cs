using MVCProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCProject.Service
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        Course GetByName(string name);
        int Create(Course course);
        int Update(int id, Course New);
        public int Delete(int id);

    }
}
