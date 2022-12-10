using BurgerApp.DAL.Repositories.Interfaces;
using BurgerApp.DbModels;
using BurgerApp.InterfaceModels;
using BurgerApp.Mappers;
using BurgerApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repository;
        private readonly IRepository<Burger> _BurgerRepository;


        public OrderService(IRepository<Order> repository, IRepository<Burger> BurgerRepository)
        {
            _repository = repository;
            _BurgerRepository = BurgerRepository;
        }

        public void Add(OrderViewModel model)
        {
            _repository.Add(OrderMapper.ToOrder(model));

        }

        public IEnumerable<OrderViewModel> GetAll()
        {
            var data = _repository.GetAll();
            
            return data.Select(x => OrderMapper.ToOrderViewModel(x));
        }
    }
}
