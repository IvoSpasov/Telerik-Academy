using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManagement.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> All();

        //T GetById(int id);

        T GetByUsername(string username);

        void Add(T entity);

        //void Update(T entity);

        //void Delete(T entity);

        //void Delete(int id);

        bool FileExists();
    }
}
