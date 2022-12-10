using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BurgerApp.InterfaceModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }

        public string Burger { get; set; }
        public string Location { get; set; }

        public List<SelectListItem> Locations { get; set; }
        public int LocationSelected { get; set; }
        public List<SelectListItem> Burgers { get; set; }
        public int BurgerSelected { get; set; }






    }
}
