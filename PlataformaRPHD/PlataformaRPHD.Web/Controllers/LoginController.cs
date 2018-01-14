using Microsoft.Owin.Security;
using PlataformaRPHD.Infrastructure.Data;
using PlataformaRPHD.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PlataformaRPHD.Web.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index(string returnUrl)
        {
            return View(returnUrl);
        }
        
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(UserViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var authService = new AdAuthenticationService(AuthenticationManager);

            bool isValidAdUser = authService.ValidateCredentials(model.Username, model.Password);

            if (isValidAdUser)
            {
                
                AdAuthenticationService.AuthenticationResult authenticationResult = authService.SignIn(model.Username, model.Password);

                if (authenticationResult.IsSuccess)
                {
                    // we are in!
                    return RedirectToAction(returnUrl);
                }
            }
            return View();
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
    }
}