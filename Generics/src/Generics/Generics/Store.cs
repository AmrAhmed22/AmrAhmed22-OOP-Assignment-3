using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Store<T> where T : IHasID
    {
        private readonly Dictionary<int,T> objects = new();

        public void Add(T obj)
        {
            if (obj == null)
                throw new NullReferenceException("Student is NULL.");

          

            if (!objects.TryAdd(obj.ID, obj))
                throw new ArgumentException($"the item with Id {obj.ID} already exists.");

        }

        public T? GetById(int id)
        {
            if (id < 0)
                throw new ArgumentException("ID must be postive.");


            return objects.TryGetValue(id, out var val) ? val : default;

        }


        public IEnumerable<T> GetAll() // readonly outside,no add or remove
        {
            return objects.Values;
        }

        public bool Remove(int id)
        {

            if (id < 0)
                throw new ArgumentException("ID must be postive.");


            return objects.Remove(id);

        }


    }
}
