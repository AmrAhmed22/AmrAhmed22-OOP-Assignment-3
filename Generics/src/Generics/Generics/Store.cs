using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Store<T> where T : IHasID
    {
        private readonly List<T> objects = new();

        public void Add(T obj)
        {
            if (obj == null)
                throw new NullReferenceException("Student is NULL.");

            objects.Add(obj);

        }

        public T? GetById(int id)
        {
            if (id < 0)
                throw new ArgumentException("ID must be postive.");


            foreach (var o in objects)
            {
                if (o.ID == id) // compiled fine now, no error after implement the interface
                    return o;

            }
            return default;
        }


        public List<T> GetAll()
        {
            return objects;
        }

        public bool Remove(int id)
        {

            if (id < 0)
                throw new ArgumentException("ID must be postive.");


            foreach (var o in objects)
            {
                if (o.ID == id)
                {
                    objects.Remove(o);
                    return true;
                }
            }


            return false;


        }


    }
}
