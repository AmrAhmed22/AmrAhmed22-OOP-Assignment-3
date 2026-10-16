using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class EnumerableExtensions 
    {

        public static IEnumerable<T> Page<T>(this IEnumerable<T> mylist , int pageNumber, int pageSize) 
        {
            if (pageNumber < 1 || pageSize < 1)
                throw new ArgumentException("Page Parameters Must be postive!");


            int skipCount = (pageNumber - 1) * pageSize;//how many items we should skip at first

            int count = 0;//to check if we arrived to our scoped items or not yet

            int yielded = 0;// count of what actually we returned,to not exceed the page size


            //if it was normal list i could begin loop after skipcount directly , but unfortunately no index here  ):
            foreach (var item in mylist)
            {
                if (count >= skipCount)
                {
                    yield return item;
                    yielded++;
                }
                count++;

                if (yielded >= pageSize) //stop now no more needed
                    yield break;
            }
        }

        public static T? FindById<T>(this IEnumerable<T> mylist, int id) where T : IHasID //to see the id like the past problem
        {
            foreach (var item in mylist)
            {
                if (item.ID == id)
                    return item;
            }
            return default;
        }

        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> mylist) where T : IHasID
        {
            var dict = new Dictionary<int, T>();

            foreach (var item in mylist)
            {
                dict[item.ID] = item;
            }


            return dict;
        }
    }
}
