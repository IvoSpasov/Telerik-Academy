using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersManagement.Data;
using UsersManagement.Data.Models;
using UsersManagement.Web.ViewModels;


namespace UsersManagement.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepository<User> users;

        public AccountController(IRepository<User> users)
        {
            this.users = users;
        }

        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(UserViewModel inputUser)
        {
            if (ModelState.IsValid)
            {
                this.users.Add(new User(inputUser.Username, inputUser.Password));
                return RedirectToAction("Login", inputUser);
            }
            
            return View(inputUser);
        }

        [HttpGet]
        public ActionResult Login(UserViewModel registeredUser)
        {
            return View(registeredUser);
        }
    }
}