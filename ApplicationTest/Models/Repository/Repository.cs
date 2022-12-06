using System.Collections.Generic;
using System.Linq;

namespace ApplicationTest.Models.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Dictionary<int, List<T>> items;
        public Dictionary<int, List<T>> Items => items;

        public Repository() =>
            items = new Dictionary<int, List<T>>();

        public IEnumerable<T> GetAllByCategory(int category) =>
           items[category];

        public void AddObject(int category, T item) =>
            items[category].Add(item);

        public void AddRange(int category, IEnumerable<T> range)
        {
            var list = items[category];

            foreach (var item in range)
            {
                list.Add(item);
            }
        }

        public void Create(int category, T item) {
            var list = new List<T>();
            list.Add(item);
            items.Add(category, list);
        }

        public void CreateRange(int category, IEnumerable<T> range) =>
            items.Add(category, range.ToList()); 
    }
}
