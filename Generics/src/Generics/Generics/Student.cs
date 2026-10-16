using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Student : IHasID
    {
        public Student(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int ID { get; private set; }
        public string Name { get; private set; }





    }
}
