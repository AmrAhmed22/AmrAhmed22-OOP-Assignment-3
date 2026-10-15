using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class StudentStore
    {
        List<Student> students = new();

        public void Add(Student student)
        {
            if (student == null)
                throw new NullReferenceException("Student is NULL.");

            students.Add(student);

        }

        public Student GetById(int id)
        {
            if (id < 0)
                throw new ArgumentException("ID must be postive.");


            foreach (var s in students)
            {
                if(s.ID

            }

        }


        public List<Student> GetAll()
        {
            return students;
        }

        public void Remove(int id)
        {


        }

    }
}
