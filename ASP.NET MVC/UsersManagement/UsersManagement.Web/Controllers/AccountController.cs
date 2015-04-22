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
            this.users.Add(new User() { Id = 1, Username = inputUser.Username, Password = inputUser.Password });
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}