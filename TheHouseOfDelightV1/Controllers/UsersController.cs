using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheHouseOfDelightV1.DbModel;
using TheHouseOfDelightV1.Models;

namespace TheHouseOfDelightV1.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;

        private readonly ApplicationDbContext dbContext;
        public UsersController(ILogger<UsersController> logger, ApplicationDbContext dbC)
        {
            _logger = logger;
            this.dbContext = dbC;
        }
        public IActionResult Users()
        {
            var Users = dbContext.Users.ToList();
            return View(Users);
        }
        public IActionResult AddNewUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewUser(Users model)
        {
            var Users = new Users();
            Users.Name = model.Name;
            Users.Surname = model.Surname;
            Users.Email = model.Email;
            Users.Password = model.Password;
            Users.City = model.City;
            dbContext.Users.Add(Users);
            dbContext.SaveChanges();
            return Redirect("/Users/Users");
        }

        public IActionResult EditUser(int Id)
        {
            var Users = dbContext.Users.Where(x => x.ID == Id).FirstOrDefault();

            return View(Users);

        }

        [HttpPost]
        public IActionResult EditUser(Users model)
        {
            var Users = dbContext.Users.Where(x => x.ID == model.ID).FirstOrDefault();
            Users.Name = model.Name;
            Users.Surname = model.Surname;
            Users.Email = model.Email;
            Users.Password = model.Password;
            Users.City = model.City;
            dbContext.SaveChanges();
            return Redirect("/Users/Users");
        }
        [HttpPost]
        public IActionResult DeleteUsers(int ID)
        {
            var Users = dbContext.Users.Where(x => x.ID == ID).FirstOrDefault();
            dbContext.Users.Remove(Users);
            dbContext.SaveChanges();
            return Redirect("/Users/Users");
        }

       
    }
}
