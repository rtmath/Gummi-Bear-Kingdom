﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;

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

        public IActionResult Details(int id)
        {
            var selectedProduct = db.Products.FirstOrDefault(p => p.Id == id);
            return View(selectedProduct);
        }
    }
}
