using BurgerApp.DbModels;
using BurgerApp.InterfaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Mappers
{
    public static class BurgerMapper
    {
        public static BurgerViewModel ToBurgerViewModel(Burger model)
        {
            return new BurgerViewModel
            {
                Name = model.Name,
                HasFries = model.HasFries,
                IsVegan = model.IsVegan,
                IsVegetarian = model.IsVegetarian,
                Price = model.Price,
                Id = model.Id,
            };
        }

        public static Burger ToBurgerDbModel(BurgerViewModel model)
        {
            return new Burger
            {
                Name = model.Name,
                HasFries = model.HasFries,
                IsVegan = model.IsVegan,
                IsVegetarian = model.IsVegetarian,
                Price = model.Price,
            };
        }
    }
}
