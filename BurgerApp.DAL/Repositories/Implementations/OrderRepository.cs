using BurgerApp.DAL.Repositories.Interfaces;
using BurgerApp.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DAL.Repositories.Implementations
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public void Add(Order entity)
        {
            _appDbContext.Orders.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetAll()
        {
            return _appDbContext.Orders;

        }
        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
