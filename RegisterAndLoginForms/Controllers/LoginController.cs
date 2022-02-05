using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginForms.Models;

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
            // sending the UserModel obj to the success page
            if (userModel.UserName == "Hello World" && userModel.Password == "123456")
                return View("LoginSuccess", userModel);
            else
                return View("LoginFailure", userModel);

        }
    }
}
