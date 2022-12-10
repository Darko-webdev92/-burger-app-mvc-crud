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
    public class BurgerService : IBurgerService
    {
        private readonly IRepository<Burger> _repository;
        public BurgerService(IRepository<Burger> repository)
        {
            _repository = repository;
        }
        public void Add(BurgerViewModel model)
        {
            _repository.Add(BurgerMapper.ToBurgerDbModel(model));
        }

        public void DeleteById(int id)
        {

           var burger = _repository.GetById(id);
            _repository.Delete(burger);
        }

        public IEnumerable<BurgerViewModel> GetAll()
        {
            var data = _repository.GetAll();
            return data.Select(x => BurgerMapper.ToBurgerViewModel(x));
        }

        public BurgerViewModel GetById(int id)
        {
            var data = _repository.GetById(id);
            return BurgerMapper.ToBurgerViewModel(data);
        }

        public void Update(BurgerViewModel model)
        {

            var burger = _repository.GetById(model.Id);
            burger.Name = model.Name;
            burger.HasFries = model.HasFries;
            burger.IsVegetarian = model.IsVegetarian;
            burger.IsVegan = model.IsVegan;
            burger.Price = model.Price;

            _repository.Update(burger);
        }
    }
}
