using BurgerApp.InterfaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Interfaces
{
    public interface IOrderService
    {
        public void Add(OrderViewModel model);
        public IEnumerable<OrderViewModel> GetAll();

    }
}
