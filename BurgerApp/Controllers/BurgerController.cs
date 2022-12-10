using BurgerApp.DAL;
using BurgerApp.Data;
using BurgerApp.InterfaceModels;
using BurgerApp.Models;
using BurgerApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BurgerApp.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerService _burgerService;
        public BurgerController(IBurgerService burgerService)
        {
             _burgerService = burgerService;
        }
        
        [HttpGet]
        public IActionResult CreateBurger()
        {
            return View("Create" ,new BurgerViewModel());
        }

        [HttpPost]
        public IActionResult CreateBurger(BurgerViewModel model)
        {
            _burgerService.Add(model);
            return RedirectToAction("GetAllBurgers");
        }

        [HttpGet]
        public IActionResult GetAllBurgers()
        {
            var data = _burgerService.GetAll();
            return View("Burgers", data);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var burger = _burgerService.GetById(id);
            return View(burger);
        }

        [HttpPost]
        public IActionResult Edit(BurgerViewModel model)
        {
            if (ModelState.IsValid)
            {
                _burgerService.Update(model);
            }
            return RedirectToAction("GetAllBurgers");
        }

        [HttpGet]
        public IActionResult Delete( int id)
        {
             _burgerService.DeleteById(id);
            return RedirectToAction("GetAllBurgers");
        }





        //    private readonly AppDbContext db;

        //    public BurgerController(AppDbContext _db)
        //    {
        //        db = _db;
        //    }
        //    public IActionResult Index()
        //    {
        //        //IEnumerable<Burger> list = db.Burgers;

        //        //var list = db.Burgers.ToList();
        //        //return View(list);
        //    }

        //    public IActionResult Create()
        //    {
        //        return View(new Burger());
        //    }

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public IActionResult Create(Burger model)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Burgers.Add(model);
        //            db.SaveChanges();
        //            TempData.Add("success","Burger created successfully");
        //            return RedirectToAction("Index");
        //        }
        //; return View(model);

        //    }



        //    public IActionResult Edit(int? id)
        //    {
        //        if (id == null || id == 0)
        //        {
        //            return NotFound();
        //        }

        //        var item = db.Burgers.FirstOrDefault(x => x.BurgerId == id);
        //        if (item == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(item);
        //    }

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public IActionResult Edit(Burger model)
        //    {

        //        if (ModelState.IsValid)
        //        {
        //            db.Burgers.Update(model);
        //            db.SaveChanges();
        //            TempData.Add("success", "Burger updated successfully");
        //            return RedirectToAction("Index");
        //        }
        //; return View(model);

        //    }
        //    [HttpGet]
        //    public IActionResult Delete(int? id)
        //    {
        //        if (id == null || id == 0)
        //        {
        //            return NotFound();
        //        }

        //        var item = db.Burgers.FirstOrDefault(x => x.BurgerId == id);
        //        if (item == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(item);
        //    }

        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public IActionResult Delete(Burger model)
        //    {

        //        var item = db.Burgers.Find(model.BurgerId);
        //        if (item == null)
        //        {
        //            return NotFound();

        //        }
        //        db.Burgers.Remove(item);
        //        db.SaveChanges();
        //        TempData.Add("success", "Burger deleted successfully");
        //        return RedirectToAction("Index");
        //    }
    }
}
