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
            if(!ModelState.IsValid)
            {
                return View(loginUserDto);
            }
            var result = await _signInManager.PasswordSignInAsync(loginUserDto.UserName, loginUserDto.Password, false, false);
            if(!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı");
                return View(loginUserDto);  //bu şekilde durdurmazsak yine return redirectToAction satırını ekrana getirir. Yanlış olsa bile girilen bilgiler.
            }
            
            return RedirectToAction("Index", "Staff");
        }
    }
}
