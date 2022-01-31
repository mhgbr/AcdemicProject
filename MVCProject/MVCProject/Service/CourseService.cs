using MVCProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCProject.Service
{
    class CourseService : ICourseService
    {
        public DBFile Context { get; }

        public CourseService(DBFile context)
        {
            Context = context;
        }

        public List<Course> GetAll()
        {
            return Context.Courses.ToList();
        }

        public Course GetById(int id)
        {
            return Context.Courses.FirstOrDefault(c => c.Id == id);
        }

        public Course GetByName(string name)
        {
            return Context.Courses.FirstOrDefault(c => c.Name == name);
        }

        public int Create(Course course)
        {
            Context.Add(course);
            return Context.SaveChanges();
        }

        public int Update(Course Newcrs)
        {
            Context.Update(Newcrs);

            return Context.SaveChanges();
        }

        public int Delete(int id)
        {
            Course course = Context.Courses.FirstOrDefault(c => c.Id == id);
            Context.Remove(course);
            return Context.SaveChanges();
        }
    }
}