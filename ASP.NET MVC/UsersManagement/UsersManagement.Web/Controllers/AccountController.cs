namespace UsersManagement.Web.Controllers
{
    using System;
    using System.Web.Mvc;

    using UsersManagement.Data;
    using UsersManagement.Data.Models;
    using UsersManagement.Web.ViewModels;

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
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(UserViewModel inputUser)
        {
            if (ModelState.IsValid)
            {
                if (this.users.GetByUsername(inputUser.Username) != null)
                {
                    ViewBag.userExists = true;
                    return this.View(inputUser);
                }

                this.users.Add(new User(inputUser.Username, inputUser.Password));
                this.TempData["CurrentUser"] = inputUser;
                return this.RedirectToAction("Login");
            }

            return this.View(inputUser);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return this.View(this.TempData["CurrentUser"]);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserViewModel inputUser)
        {
            if (ModelState.IsValid)
            {
                User foundUser = this.users.GetByUsername(inputUser.Username);
                ViewBag.userExists = true;
                if (foundUser == null)
                {
                    ViewBag.userExists = false;
                    return this.View(inputUser);
                }

                if (!this.SamePasswords(inputUser, foundUser))
                {
                    ViewBag.samePasswords = false;
                    return this.View(inputUser);
                }

                return this.RedirectToAction("Details", new { id = inputUser.Username });
            }

            return this.View(inputUser);
        }

        private bool SamePasswords(UserViewModel inputUser, User foundUser)
        {
            string inputPasswordAsSha1 = Sha1Hash.Sha1HashStringForUtf8String(inputUser.Password);
            bool passwordsMatch = foundUser.Password == inputPasswordAsSha1;
            return passwordsMatch;
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return this.View("Error");
            }

            User foundUser = this.users.GetByUsername(id);
            if (foundUser == null)
            {
                return this.View("Error");
            }

            UserViewModel foundUserViewModel = new UserViewModel();
            foundUserViewModel.Username = foundUser.Username;
            foundUserViewModel.Password = foundUser.Password;
            return this.View(foundUserViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(UserViewModel inputUser)
        {
            if (ModelState.IsValid)
            {
                var foundUser = this.users.GetByUsername(inputUser.Username);

                if (foundUser == null)
                {
                    return this.View("Error");
                }

                foundUser.Password = Sha1Hash.Sha1HashStringForUtf8String(inputUser.Password);

                this.users.Update(foundUser);
            }

            return this.View(inputUser);
        }
    }
}