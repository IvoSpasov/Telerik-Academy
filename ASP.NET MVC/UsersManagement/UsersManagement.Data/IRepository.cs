namespace UsersManagement.Data
{
    using System.Collections.Generic;

    public interface IRepository<T> where T : class
    {
        IEnumerable<T> All();

        T GetById(int id);

        T GetByUsername(string username);

        void Add(T entity);

        void Update(T entity);

        // void Delete(T entity);

        // void Delete(int id);
    }
}
