using BurgerApp.DbModels;
using BurgerApp.InterfaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Mappers
{
    public static class OrderMapper
    {
        public static Order ToOrder(OrderViewModel model)
        {
            return new Order
            {
                Address = model.Address,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsDelivered = model.IsDelivered,
                LocationId = model.LocationSelected,
                BurgerId = model.BurgerSelected,

            };
        }

        public static OrderViewModel ToOrderViewModel(Order model)
        {
            return new OrderViewModel
            {
                Address = model.Address,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsDelivered = model.IsDelivered,
                Id = model.Id,
                BurgerSelected = model.BurgerId,
                LocationSelected = model.LocationId,
            };
        }
    }
}
