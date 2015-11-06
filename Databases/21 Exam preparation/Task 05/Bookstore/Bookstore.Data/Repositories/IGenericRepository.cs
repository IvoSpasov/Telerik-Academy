namespace Bookstore.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    interface IGenericRepository<T>
    {
        IQueryable<T> All();

        IQueryable<T> Search(Expression<Func<T, bool>> conditions);

        void Add(T entity);

        T Delete(T entity);

        void Update(T entity);

        void Detach(T entity);
    }
}
