using BurgerApp.DAL.Repositories.Interfaces;
using BurgerApp.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DAL.Repositories.Implementations
{
    public class BurgerRepository : IRepository<Burger>
    {
        private readonly AppDbContext _appDbContext;


        public BurgerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add(Burger entity)
        {
            _appDbContext.Burgers.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Burger entity)
        {
            _appDbContext.Burgers.Remove(entity);
            _appDbContext.SaveChanges();

        }

        public IQueryable<Burger> GetAll()
        {
            return _appDbContext.Burgers;
        }

        public Burger GetById(int id)
        {
           var data = _appDbContext.Burgers.Where(b => b.Id == id).FirstOrDefault();
            return data;
        }

        public void Update(Burger entity)
        {
            _appDbContext.Burgers.Update(entity);
            _appDbContext.SaveChanges();
        }

    }
}
