using BurgerApp.InterfaceModels;
using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult CreateLocation()
        {
            return View("Create", new LocationViewModel());
        }

        [HttpPost]
        public IActionResult CreateLocation(LocationViewModel model)
        {
            _locationService.Add(model);
            return RedirectToAction("GetAllLocations");
        }

        [HttpGet]
        public IActionResult GetAllLocations()
        {
            var data = _locationService.GetAll();
            return View("Locations", data);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var burger = _locationService.GetById(id);
            return View(burger);
        }

        [HttpPost]
        public IActionResult Edit(LocationViewModel model)
        {
            if (ModelState.IsValid)
            {
                _locationService.Update(model);
            }
            return RedirectToAction("GetAllLocations");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _locationService.DeleteById(id);
            return RedirectToAction("GetAllLocations");
        }
    }
}
