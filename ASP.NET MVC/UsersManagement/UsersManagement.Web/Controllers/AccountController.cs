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
                if (this.UserExists(inputUser))
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
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserViewModel inputUser)
        {
            if (ModelState.IsValid)
            {
                User foundUser = null;
                ViewBag.userExists = true;
                if (!this.UserExists(inputUser, out foundUser))
                {
                    ViewBag.userExists = false;
                    return View(inputUser);
                }
                if (!SamePasswords(inputUser, foundUser))
                {
                    ViewBag.samePasswords = false;
                    return View(inputUser);
                }

                return this.RedirectToAction("Index", "Home");
            }

            return this.View(inputUser);
        }

        private bool UserExists(UserViewModel inputUser)
        {
            User foundUSer = null;
            return UserExists(inputUser, out foundUSer);
        }

        private bool UserExists(UserViewModel inputUser, out User foundUser)
        {
            if (!this.users.FileExists())
            {
                foundUser = null;
                return false;
            }

            var allUsers = this.users.All();
            foundUser = allUsers.FirstOrDefault(u => u.Username.ToLower() == inputUser.Username.ToLower());
            return foundUser != null ? true : false;
        }

        private bool SamePasswords(UserViewModel inputUser, User foundUser)
        {
            string inputPasswordAsSha1 = Sha1Hash.Sha1HashStringForUtf8String(inputUser.Password);
            bool passwordsMatch = foundUser.Password == inputPasswordAsSha1;
            return passwordsMatch;
        }

        public ActionResult Details(string id)
        {
            return View();
        }
    }
}