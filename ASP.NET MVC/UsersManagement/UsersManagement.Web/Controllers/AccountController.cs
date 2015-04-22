using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersManagement.Data;
using UsersManagement.Web.ViewModels;


namespace UsersManagement.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserToXml users;

        public AccountController(IUserToXml users)
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
            users.AddNewUser(inputUser.Username, inputUser.Password);
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}