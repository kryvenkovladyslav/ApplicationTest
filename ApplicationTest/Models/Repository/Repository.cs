using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTest.Models.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Dictionary<int, List<T>> items;
        public Dictionary<int, List<T>> Items => items;

        public Repository()
        {
            items = new Dictionary<int, List<T>>();
        }

        public void Add(int category, T item)
        {
            items[category].Add(item);
        }

        public void AddRange(int category, IEnumerable<T> range)
        {
            items.Add(category, range.ToList());
        }

        public IEnumerable<T> GetAllByCategory(int category)
        {
            return items[category];
        }
    }
}
