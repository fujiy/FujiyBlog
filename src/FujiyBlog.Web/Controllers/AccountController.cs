﻿using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using FujiyBlog.Web.Models;
using FujiyBlog.Core.Services;
using FujiyBlog.Web.Extensions;

namespace FujiyBlog.Web.Controllers
{
    public partial class AccountController : Controller
    {
        private readonly UserService userService;

        public IFormsAuthenticationService FormsService { get; set; }

        public AccountController(UserService userService)
        {
            this.userService = userService;
        }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }

            base.Initialize(requestContext);
        }

        public virtual ActionResult LogOn()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction(MVC.Account.ChangePassword());
            }
            return View();
        }

        [HttpPost]
        public virtual ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (userService.ValidateUser(model.UserName, model.Password))
                {
                    FormsService.SignIn(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction(MVC.Post.Index());
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public virtual ActionResult LogOff()
        {
            FormsService.SignOut();

            return RedirectToAction(MVC.Post.Index());
        }

        // **************************************
        // URL: /Account/Register
        // **************************************

        public virtual ActionResult Register()
        {
            ViewBag.PasswordLength = Settings.SettingRepository.MinRequiredPasswordLength;
            return View();
        }

        [HttpPost]
        public virtual ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                CreateUserResult createStatus = userService.CreateUser(model.UserName, model.Password, model.Email);

                if (!createStatus.RuleViolations.Any())
                {
                    FormsService.SignIn(model.UserName, false /* createPersistentCookie */);
                    return RedirectToAction(MVC.Post.Index());
                }
                ModelState.Merge(createStatus.RuleViolations);
            }

            // If we got this far, something failed, redisplay form
            ViewBag.PasswordLength = Settings.SettingRepository.MinRequiredPasswordLength;
            return View(model);
        }

        [Authorize]
        public virtual ActionResult ChangePassword()
        {
            ViewBag.PasswordLength = Settings.SettingRepository.MinRequiredPasswordLength;
            return View();
        }

        [Authorize]
        [HttpPost]
        public virtual ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                if (userService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword))
                {
                    return RedirectToAction(MVC.Account.ChangePasswordSuccess());
                }
                else
                {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            ViewBag.PasswordLength = Settings.SettingRepository.MinRequiredPasswordLength;
            return View(model);
        }

        // **************************************
        // URL: /Account/ChangePasswordSuccess
        // **************************************

        public virtual ActionResult ChangePasswordSuccess()
        {
            return View();
        }

    }
}
