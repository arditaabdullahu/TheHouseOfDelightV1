using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheHouseOfDelightV1.DbModel;
using TheHouseOfDelightV1.Models;

namespace TheHouseOfDelightV1.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}