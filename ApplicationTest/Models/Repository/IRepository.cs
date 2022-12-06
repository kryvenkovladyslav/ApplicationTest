using System.Collections.Generic;

namespace ApplicationTest.Models.Repository
{
    public interface IRepository<T> where T: class
    {
        public IEnumerable<T> GetAllByCategory(int category);
        public void AddObject(int category, T item);
        public void AddRange(int category, IEnumerable<T> range);
        public void Create(int category, T item);
        public void CreateRange(int category, IEnumerable<T> range);
    }
}
