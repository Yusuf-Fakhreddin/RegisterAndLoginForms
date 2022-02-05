using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginForms.Models;
using RegisterAndLoginForms.Services;

namespace RegisterAndLoginForms.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // expecting a UserModel Obj 
        public IActionResult ProcessLogin(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();
            // sending the UserModel obj to the success page
            if (securityService.IsValid(userModel))
                return View("LoginSuccess", userModel);
            else
                return View("LoginFailure", userModel);

        }
    }
}
