using BurgerApp.DbModels;
using BurgerApp.InterfaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Mappers
{
    public static class LocationMapper
    {
        public static Location ToLocation(LocationViewModel model)
        {
            return new Location
            {
                Address = model.Address,
                ClosesAt = model.ClosesAt,
                Name = model.Name,
                OpensAt = model.OpensAt,
            };
        }

        public static LocationViewModel ToLocationViewModel(Location model)
        {
            return new LocationViewModel
            {
                Address = model.Address,
                ClosesAt = model.ClosesAt,
                Name = model.Name,
                OpensAt = model.OpensAt,
                Id = model.Id
            };
        }
    }
}
