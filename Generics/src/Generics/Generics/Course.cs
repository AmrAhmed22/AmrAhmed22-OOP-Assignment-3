using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Course : IHasID
    {
        public Course(int iD, string title, double price)
        {
            ID = iD;
            Title = title;
            Price = price;
        }

        public int ID { get; private set; }
        public string Title { get; private set; }
        public double Price { get; private set; }


    }
}
