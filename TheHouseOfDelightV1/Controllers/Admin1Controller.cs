using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheHouseOfDelightV1.DbModel;

namespace TheHouseOfDelightV1.Controllers
{
    public class Admin1Controller : Controller
    {
        private readonly ILogger<Admin1Controller> _logger;

        private readonly ApplicationDbContext dbContext;
        public Admin1Controller(ILogger<Admin1Controller> logger, ApplicationDbContext dbC)
        {
            _logger = logger;
            this.dbContext = dbC;
        }
        public IActionResult Food()
        {
            var Foods = dbContext.Foods.ToList();
            return View(Foods);
           
        }
       
       
        public IActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNew(Food model)
        {
            var Food = new Food();
            Food.Name = model.Name;
            Food.Description = model.Description;
            Food.PrepTime = model.PrepTime;
            Food.CookTime = model.CookTime;
            Food.TotatTime = model.TotatTime;
            Food.Servings = model.Servings;
            dbContext.Foods.Add(Food);
            dbContext.SaveChanges();
            return Redirect("/Admin1/Food");
        }

        public IActionResult Edit(int Id)
        {
            var Food = dbContext.Foods.Where(x => x.ID == Id).FirstOrDefault();

            return View(Food);

        }

        [HttpPost]
        public IActionResult Edit(Food model)
        {
            var Food = dbContext.Foods.Where(x => x.ID == model.ID).FirstOrDefault();
            Food.Name = model.Name;
            Food.Description = model.Description;
            Food.PrepTime = model.PrepTime;
            Food.CookTime = model.CookTime;
            Food.TotatTime = model.TotatTime;
            Food.Servings = model.Servings;
            dbContext.SaveChanges();
            return Redirect("/Admin1/Food");
        }

        public IActionResult Products()
        {
            var Produktet = dbContext.Products.ToList();
            return View(Produktet);

        }

        public IActionResult EditProduct(int Id)
        {
            var Product = dbContext.Products.Where(x => x.ID == Id).FirstOrDefault();

            return View(Product);

        }

        [HttpPost]
        public IActionResult EditProduct(Product model)
        {
            var Product = dbContext.Products.Where(x => x.ID == model.ID).FirstOrDefault();
            Product.Name = model.Name;
            Product.Description = model.Description;
            dbContext.SaveChanges();
            return Redirect("/Admin1/Products");
        }

        public IActionResult AddNewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product model)
        {
            var Product = new Product();
            Product.Name = model.Name;
            Product.Description = model.Description;
            dbContext.Products.Add(Product);
            dbContext.SaveChanges();
            return Redirect("/Admin1/Products");
        }


        public IActionResult Types()
        {
            var Tipet = dbContext.Types.ToList();
            return View(Tipet);
        }
        public IActionResult EditTypes(int Id)
        {
            var Types = dbContext.Types.Where(x => x.ID == Id).FirstOrDefault();

            return View(Types);

        }

        [HttpPost]
        public IActionResult EditTypes(Types model)
        {
            var Types = dbContext.Types.Where(x => x.ID == model.ID).FirstOrDefault();
            Types.Name = model.Name;
            Types.Description = model.Description;
            dbContext.SaveChanges();
            return Redirect("/Admin1/Types");
        }

        public IActionResult AddNewTypes()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewTypes(Types model)
        {
            var Types = new Types();
            Types.Name = model.Name;
            Types.Description = model.Description;
            dbContext.Types.Add(Types);
            dbContext.SaveChanges();
            return Redirect("/Admin1/Types");
        }


        [HttpPost]
        public IActionResult DeleteFood(int ID)
        {
            var Food = dbContext.Foods.Where(x => x.ID == ID).FirstOrDefault();
            dbContext.Foods.Remove(Food);
            dbContext.SaveChanges();
            return Redirect("/Admin1/Food");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int ID)
        {
            var Products = dbContext.Products.Where(x => x.ID == ID).FirstOrDefault();
            dbContext.Products.Remove(Products);
            dbContext.SaveChanges();
            return Redirect("/Admin1/Products");
        }

        [HttpPost]
        public IActionResult DeleteTypes(int ID)
        {
            var Types = dbContext.Types.Where(x => x.ID == ID).FirstOrDefault();
            dbContext.Types.Remove(Types);
            dbContext.SaveChanges();
            return Redirect("/Admin1/Types");
        }
    }
}