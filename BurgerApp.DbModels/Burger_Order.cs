using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DbModels
{
    public class Burger_Order
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


        public int BurgerId { get; set; }
        public Burger Burger { get; set; }



    }
}
