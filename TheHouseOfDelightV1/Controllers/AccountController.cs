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
    public class AccountController : Controller
    {

        private readonly ApplicationDbContext dbContext;
        public AccountController(ApplicationDbContext dbC)
        {
            this.dbContext = dbC;
        }
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(string UserName, string Password)
        {
            
            return Redirect("/Account/LogIn");
        }


        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Users model)
        {
            var SignUp = new Users();
            SignUp.Name = model.Name;
            SignUp.Surname = model.Surname;
            SignUp.Email = model.Email;
            SignUp.Password = model.Password;
            SignUp.City = model.City;
            dbContext.Users.Add(SignUp);
            dbContext.SaveChanges();
            return Redirect("/Account/SignUp");
        }
    }
}