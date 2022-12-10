using BurgerApp.DAL.Repositories.Interfaces;
using BurgerApp.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DAL.Repositories.Implementations
{
    public class LocationRepository : IRepository<Location>
    {
        private readonly AppDbContext _appDbContext;

        public LocationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public void Add(Location entity)
        {
            _appDbContext.Locations.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Location entity)
        {
            _appDbContext.Locations.Remove(entity);
            _appDbContext.SaveChanges();

        }

        public IQueryable<Location> GetAll()
        {
            return _appDbContext.Locations;
        }

        public Location GetById(int id)
        {
            var data = _appDbContext.Locations.Where(b => b.Id == id).FirstOrDefault();
            return data;
        }

        public void Update(Location entity)
        {
            _appDbContext.Locations.Update(entity);
            _appDbContext.SaveChanges();
        }

    }
}
