using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CourseStore
    {
        private readonly List<Course> courses = new();

        public void Add(Course course)
        {
            if (course == null)
                throw new NullReferenceException("Student is NULL.");

            courses.Add(course);

        }

        public Course? GetById(int id)
        {
            if (id < 0)
                throw new ArgumentException("ID must be postive.");


            foreach (var c in courses)
            {
                if (c.ID == id)
                    return c;

            }
            return null;
        }


        public List<Course> GetAll()
        {
            return courses;
        }

        public bool Remove(int id)
        {

            if (id < 0)
                throw new ArgumentException("ID must be postive.");


            foreach (var c in courses)
            {
                if (c.ID == id)
                {
                    courses.Remove(c);
                    return true;
                }
            }


            return false;


        }



    }
}
