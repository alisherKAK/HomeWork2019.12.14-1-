using System.Collections.Generic;

namespace HomeWork2019._12._14_1_.AbstractModels
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Delete(T item);
        void Delete(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
    }
}
