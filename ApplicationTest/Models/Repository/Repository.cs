using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTest.Models.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Dictionary<string, List<T>> items;
        public Repository()
        {
            items = new Dictionary<string, List<T>>();
        }

        public void Add(string category, T item)
        {
            items[category].Add(item);
        }

        public void AddRange(string category, IEnumerable<T> range)
        {
            items.Add(category, range.ToList());
            /*var enumerable = items[category];

            foreach (var item in range)
            {
                if (!enumerable.Contains(item))
                {
                    enumerable.Add(item);
                }
            }*/
        }

        public IEnumerable<T> GetAllByCategory(string category)
        {
            return items[category];
        }

        
    }

}
