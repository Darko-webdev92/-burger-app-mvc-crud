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
    public class LocationService : ILocationService
    {

        private readonly IRepository<Location> _repository;

        public LocationService(IRepository<Location> repository)
        {
            _repository = repository;

        }
        public void Add(LocationViewModel model)
        {
            _repository.Add(LocationMapper.ToLocation(model));
        }


        public void DeleteById(int id)
        {

            var location = _repository.GetById(id);
            _repository.Delete(location);
        }

        public IEnumerable<LocationViewModel> GetAll()
        {
            var data = _repository.GetAll();
            return data.Select(x => LocationMapper.ToLocationViewModel(x));
        }

        public LocationViewModel GetById(int id)
        {
            var data = _repository.GetById(id);
            return LocationMapper.ToLocationViewModel(data);
        }

        public void Update(LocationViewModel model)
        {

            var location = _repository.GetById(model.Id);
            location.Address = model.Address;
            location.ClosesAt = model.ClosesAt;
            location.OpensAt = model.OpensAt;
            location.Name = model.Name;

            _repository.Update(location);
        }
    }
}
