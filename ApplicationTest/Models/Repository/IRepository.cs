using System.Collections.Generic;

namespace ApplicationTest.Models.Repository
{
    public interface IRepository<T> where T: class
    {
        public IEnumerable<T> GetAllByCategory(int category);
        public void Add(int category, T item);
        public void AddRange(int category, IEnumerable<T> items);
    }
}
