//namespace Bookstore.Data.Repositories
//{
//    using Bookstore.Data.Interfaces;
//    using System;
//    using System.Linq;
//    using System.Linq.Expressions;

//    public class GenericRepository<T> : IGenericRepository<T>
//    {
//        private IBookstoreDbContext context;

//        public GenericRepository(IBookstoreDbContext bookstoreContext)
//        {
//            this.context = bookstoreContext;
//        }

//        public IQueryable<T> All()
//        {
//            throw new System.NotImplementedException();
//        }

//        public IQueryable<T> Search(Expression<Func<T, bool>> conditions)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void Add(T entity)
//        {
//            throw new System.NotImplementedException();
//        }

//        public T Delete(T entity)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void Update(T entity)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void Detach(T entity)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
