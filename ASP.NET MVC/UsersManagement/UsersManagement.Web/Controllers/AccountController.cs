using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
                var allUsers = this.users.All();
                bool userExists = allUsers.Any(u => u.Username.ToLower() == inputUser.Username.ToLower());

                if (userExists)
                {
                    ViewBag.userExists = true;
                    return (View(inputUser));
                }


                this.users.Add(new User(inputUser.Username, inputUser.Password));
                TempData["CurrentUser"] = inputUser;
                return RedirectToAction("Login");
            }

            return View(inputUser);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View(TempData["CurrentUser"]);
        }

        [HttpPost]
        public ActionResult Login(UserViewModel inputUser)
        {
            if (ModelState.IsValid)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return this.View(inputUser);
        }
    }
}