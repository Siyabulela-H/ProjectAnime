using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class AnimeController1 : Controller
    {
        //This List will store the details of the Animes
        private static List<Anime> ani=new List<Anime>();

        public IActionResult Index()
        {
            return View(ani);
        }
        public IActionResult Create()
        {
            var animes = new Anime();
            return View(animes);
        }

        public IActionResult CreateAnime(Anime anim)
        {
            ani.Add(anim);
            return RedirectToAction("Index");
        }
    }
}
