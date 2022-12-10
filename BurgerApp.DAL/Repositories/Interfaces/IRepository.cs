using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        IQueryable<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);

    }
}
