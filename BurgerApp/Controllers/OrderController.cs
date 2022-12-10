using BurgerApp.InterfaceModels;
using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerApp.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderService _orderService;
        private readonly ILocationService _locationService;
        private readonly IBurgerService _burgerService;

        public OrderController(IOrderService orderService, ILocationService locationService,
            IBurgerService burgerService)
        {
            _orderService = orderService;
            _locationService = locationService;
            _burgerService = burgerService;

        }


        [HttpGet]
        public IActionResult CreateOrder()
        {
            var model = new OrderViewModel();
            model.Locations = new List<SelectListItem>();
            model.Burgers = new List<SelectListItem>();

            var locations = _locationService.GetAll();
            var burgers = _burgerService.GetAll();

            foreach (var item in locations)
            {
                model.Locations.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }

            foreach (var item in burgers)
            {
                model.Burgers.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }

            return View("Create", model);
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderViewModel model)
        {
            _orderService.Add(model);
            return RedirectToAction("GetAllOrders");
        }


        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var data = _orderService.GetAll();
            List<OrderViewModel> data1 = new List<OrderViewModel>();
            foreach (var item in data)
            {
                item.Location = _locationService.GetById(item.LocationSelected).Name;
                item.Burger = _burgerService.GetById(item.BurgerSelected).Name;
                data1.Add(item);

            }
                       
            return View("Orders", data1);
        }

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var burger = _orderService.GetById(id);
        //    return View(burger);
        //}

        //[HttpPost]
        //public IActionResult Edit(BurgerViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _orderService.Update(model);
        //    }
        //    return RedirectToAction("GetAllBurgers");
        //}

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    _orderService.DeleteById(id);
        //    return RedirectToAction("GetAllBurgers");
        //}
    }
}
