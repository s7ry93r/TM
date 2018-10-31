using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using TM.WebApp.Lib;
using TM.WebApp.ViewModels;

namespace TM.WebApp.Controllers
{
    public class AccountController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private UserManager UserMgr;

        public AccountController()
        {
            UserMgr = new UserManager();
        }

        public AccountController(UserManager userManager)
        {
            UserMgr = userManager;
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                string db_pwd = UserMgr.GetUserPwd(model.UserName);
                if (string.IsNullOrEmpty(db_pwd))
                {
                    ModelState.AddModelError("", "User Login info in the DB is no good. Contact an Administrator.");
                }
                else
                {
                    if (db_pwd.EndsWith(model.Password))
                    {
                        FormsAuthentication.RedirectFromLoginPage(model.UserName, false);
                    }
                    else
                    {
                        ModelState.AddModelError("", "User Login has Failed.");
                    }
                }

            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Logoff()
        {
            //AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }


    }
}