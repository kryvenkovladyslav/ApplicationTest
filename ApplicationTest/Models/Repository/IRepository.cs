using System.Collections.Generic;

namespace ApplicationTest.Models.Repository
{
    public interface IRepository<T> where T: class
    {
        public IEnumerable<T> GetAllByCategory(string category);
        public void Add(string category, T item);
        public void AddRange(string category, IEnumerable<T> items);
    }
}
