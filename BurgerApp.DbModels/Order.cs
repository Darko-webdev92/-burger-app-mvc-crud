using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DbModels
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }

       // Navigation properties
        public int LocationId { get; set; }
        public Location Location { get; set; }

        public int BurgerId { get; set; }
        public Burger Burger { get; set; }





    }
}
