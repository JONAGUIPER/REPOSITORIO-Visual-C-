using MVCLoginAutenticacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCLoginAutenticacion.Controllers
{
    public class CuentasController : Controller
    {
        // GET: Cuentas
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(Logueo model, string returnUrl)
        {
    //        var errors = ModelState
    //.Where(x => x.Value.Errors.Count > 0)
    //.Select(x => new { x.Key, x.Value.Errors })
    //.ToArray();
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.NombreUsuario, model.Password))
                {

                    FormsAuthentication.SetAuthCookie(model.NombreUsuario, model.RecordarMe);

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
                    ModelState.AddModelError("", "El Nombre de Usuario o Password es incorrecto");
                }
            }
            return View(model);
        }

        public ActionResult Registrar()
        {
            return View();
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
                    MembershipUser NewUser = Membership.CreateUser(model.NombreUsuario, model.Password);
                    FormsAuthentication.SetAuthCookie(model.NombreUsuario, false);
                    return RedirectToAction("Index", "Home");
                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("Registration Error",
                        "Registration error: " + e.StatusCode.ToString());
                }
            }
            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public enum ManageMessageId
        {
            ChangePasswordSuccess,
            SetPasswordSuccess,
        }

        public ActionResult ResetPassword(ManageMessageId? message)
        {
            if (message != null)
            {
                ViewBag.StatusMessage = "Your password has been changed";
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
                bool changePasswordSucceeded;
                try
                {
                    changePasswordSucceeded =
                        Membership.Provider.ChangePassword(
                            User.Identity.Name,
                            model.OldPassword,
                            model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                {
                    return RedirectToAction("ResetPassword",
                        new { message = ManageMessageId.ChangePasswordSuccess });
                }
                else
                {
                    ModelState.AddModelError("",
                        "The current password is incorrect or the new password is invalid");
                }

            }
            return View(model);
        }


    }

}