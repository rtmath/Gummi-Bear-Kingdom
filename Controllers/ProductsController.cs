using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        GummiContext db = new GummiContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var selectedProduct = db.Products.FirstOrDefault(p => p.Id == id);
            return View(selectedProduct);
        }

        public IActionResult Edit(int id)
        {
            var selectedProduct = db.Products.FirstOrDefault(p => p.Id == id);
            return View(selectedProduct);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var selectedProduct = db.Products.FirstOrDefault(p => p.Id == id);
            return View(selectedProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var selectedProduct = db.Products.FirstOrDefault(p => p.Id == id);
            db.Products.Remove(selectedProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
