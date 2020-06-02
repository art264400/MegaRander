using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Rent.Interfaces;
using Rent.Models.Tag;

namespace Rent.Controllers
{
    public class AccountController : Controller
    {
        public IRentService _rentService;

        public AccountController(IRentService rentService)
        {
            _rentService = rentService;
        }
        // GET: Account
        public ActionResult Login()
        {
            LoginTag loginModel = new LoginTag();
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginTag loginModel)
        {
            if (ModelState.IsValid)
            {

                if (_rentService.VerifyUserByLoginAndPassword(loginModel))
                {
                    FormsAuthentication.SignOut();
                    FormsAuthentication.SetAuthCookie(loginModel.Login, true);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}