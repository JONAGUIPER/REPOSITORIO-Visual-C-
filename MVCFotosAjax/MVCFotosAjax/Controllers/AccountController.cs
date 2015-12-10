using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFotosAjax.Models;
using System.Web.Security;

namespace MVCFotosAjax.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public enum ManageMeassageId
        {
            ChangePasswordSuccess,
            SetPasswordSuccess
        }

        public ActionResult ResetPassword(ManageMeassageId? message)
        {
            if (message !=null)
            {
                ViewBag.StatusMessage = "Su Password Ha sido Cambiado";
            }
            ViewBag.ReturnUrl = Url.Action("ResetPassword");
            return View();
        }

        [HttpPost]
        public ActionResult ResetPassword(LocalPassword model)
        {
            ViewBag.ReturnUrl = Url.Action("ResetPassword");
            if (ModelState.IsValid)
            {
                bool changePasswordSucceded;
                try
                {
                    changePasswordSucceded = Membership.Provider.ChangePassword(
                        User.Identity.Name,
                        model.OldPassword,
                        model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceded = false;
                }
                if (changePasswordSucceded)
                {
                    return RedirectToAction("ResetPassword", new { message = ManageMeassageId.ChangePasswordSuccess });
                }
                else
                {
                    ModelState.AddModelError("", "El password actual es incorrecto o el nuevo password es inválido");
                }
            }
            return View(model);
        }
        // GET: Account
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Login model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.UserName,model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "El usuario y/o contraseña es incorrecto");
                }
            }
            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MembershipUser NewUser = Membership.CreateUser(model.UserName, model.Password);
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("Error de registro", "Error de Registro:" + e.StatusCode);
                }
            }
            return View(model);
        }
    }
}