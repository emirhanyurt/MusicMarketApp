using Microsoft.AspNetCore.Mvc;
using MusicMarketBussines.Contracts;
using MusicMarketUI.Models;
using System.Diagnostics;

namespace MusicMarketUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMusicBussinesEnginee _musicBussinesEnginee;
        private readonly IArtistBussinesEnginee _artistBussinesEnginee;
        public HomeController(ILogger<HomeController> logger, IArtistBussinesEnginee artistBussinesEnginee, IMusicBussinesEnginee musicBussinesEnginee)
        {
            _logger = logger;
            _artistBussinesEnginee = artistBussinesEnginee;
            _musicBussinesEnginee = musicBussinesEnginee;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _artistBussinesEnginee.GetAllArtist();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}