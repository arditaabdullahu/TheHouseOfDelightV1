using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheHouseOfDelightV1.DbModel;

namespace TheHouseOfDelightV1.Controllers
{
    public class FoodController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public FoodController(ApplicationDbContext dbC)
        {
           
            this.dbContext = dbC;
        }


        public IActionResult FoodDetails(int Id)
        {

            var Food = dbContext.Foods.Where(x => x.ID == Id).FirstOrDefault();

            return View(Food);
        }
    }
}