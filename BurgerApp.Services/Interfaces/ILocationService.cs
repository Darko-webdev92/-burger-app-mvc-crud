using BurgerApp.InterfaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface ILocationService
    {

        public void Add(LocationViewModel model);
        public IEnumerable<LocationViewModel> GetAll();
        public void Update(LocationViewModel model);
        public LocationViewModel GetById(int id);
        public void DeleteById(int id);

    }
}
