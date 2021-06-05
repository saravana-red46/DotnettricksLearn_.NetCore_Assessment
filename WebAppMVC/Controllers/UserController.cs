using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;


namespace WebAppMVC.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {

            if (!ModelState.IsValid)
            {
                
            }
            return View();
        }
    }
}
