using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly BestCuisinesContext _db;

    public CuisinesController(BestCuisinesContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      //ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisine.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      return View(thisCuisine);
    }

		public ActionResult Edit(int id)
		{
			Cuisine thisCuisine = _db.Cuisine.FirstOrDefault(cuisine => cuisine.CuisineId == id);
			return View(thisCuisine);
		}

		[HttpPost]
		public ActionResult Edit(Cuisine cuisine)
		{
			_db.Entry(cuisine).State = EntityState.Modified;
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Delete(int id)
		{
			Cuisine thisCuisine = _db.Cuisine.FirstOrDefault(cuisine => cuisine.CuisineId == id);
			return View(thisCuisine);
		}

		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id)
		{
			Cuisine thisCuisine = _db.Cuisine.FirstOrDefault(cuisine => cuisine.CuisineId == id);
			_db.Cuisine.Remove(thisCuisine);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
  }
}