using BankLoginPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankLoginPage.Controllers
{
    [Route("Bank")]
    public class BankController : Controller
    {
        private BankService BankService;
        public BankController(BankService _BankService)
        {
            BankService = _BankService;
        }

        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string UserName,string Password)
        {
            var account=BankService.Login(UserName, Password);
            if(account != null)
            {
                HttpContext.Session.SetString("UserName", UserName);
                return RedirectToAction("Welcome");
            }
            else
            {
                ViewBag.msg = "Invalid";
                return View("Index");
            }
        }

        [Route("Welcome")]

        public IActionResult Welcome()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            return View("Welcome");
        }

        [Route("Logout")]

        public IActionResult Logout()
        {
           HttpContext.Session.Remove("username");
            return View("Index");
        }
    }
}
