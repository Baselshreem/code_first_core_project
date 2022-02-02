using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project1_core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace project1_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        newscontixit db ;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        public HomeController(newscontixit contixt)
        {
            db = contixt;
        }


        public IActionResult Index()
        {
           var result= db.catogris.ToList();
            return View(result);
        }

        public IActionResult contact()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult savcontact(countactus count)

        {

            db.countactus.Add(count);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult masege()
        {
           
            return View(db.countactus.ToList());
        }
        public IActionResult news(int id)
        {
            catogri c = db.catogris.Find(id);
            ViewBag.cat = c.name;

           var result= db.News.Where(e => e.id == id).OrderByDescending(x=>x.Date).ToList();
            return View(result);
        }

        public IActionResult deletnews(int id)
        {
            var news = db.News.Find(id);

            db.News.Remove(news);
            db.SaveChanges();
            return RedirectToAction("news");
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
