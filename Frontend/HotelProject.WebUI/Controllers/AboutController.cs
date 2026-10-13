using HotelProject.WebUI.Dtos.AboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
