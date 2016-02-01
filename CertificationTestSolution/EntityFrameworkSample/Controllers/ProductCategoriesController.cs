﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkSample.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private AdventureWorksEntities _context;

        public ProductCategoriesController()
        {
            _context = new AdventureWorksEntities();
        }

        // GET: ProductCategories
        public ActionResult Index()
        {
            var categories = _context.ProductCategories.OrderByDescending(c => c.ModifiedDate).Take(10).ToList();
            return View(categories);
        }

        // GET: ProductCategories/Create
        public ActionResult Create()
        {
            AddCategoriesDDL();
            return View();
        }

        private void AddCategoriesDDL()
        {
            var categories = _context.ProductCategories.ToList();
            ViewBag.ParentProductCategoryID = new SelectList(categories, "ProductCategoryID", "Name");
        }

        // POST: ProductCategories/Create
        [HttpPost]
        public ActionResult Create(ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                var retry = 0;
                Exception exception = null;
                while(retry < 5)
                {
                    try
                    {
                        model.ModifiedDate = DateTime.Now;
                        model.rowguid = new Guid();//Guid.NewGuid();
                        _context.ProductCategories.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                        retry++;
                    }
                }
                if(exception != null)
                    ModelState.AddModelError("", exception.ToString());
            }

            AddCategoriesDDL();
            return View(model);         
        }

        // GET: ProductCategories/Delete/5
        public ActionResult Delete(int id)
        {
            var category = _context.ProductCategories.FirstOrDefault(pc => pc.ProductCategoryID == id);
            if(category != null)
            {
                _context.ProductCategories.Remove(category);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
