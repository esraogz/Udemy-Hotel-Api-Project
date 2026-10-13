using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Pkcs;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class LoginController(SignInManager<AppUser> _signInManager) : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginUserDto.UserName, loginUserDto.Password, false, false);
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Staff");
            }
            else
            {
                return View();
            }
            return View();
        }
    }
}
