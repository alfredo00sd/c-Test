using Newtonsoft.Json;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Posts()
        {
            ViewBag.Message = "Your posts page.";
            ViewBag.Data = "Data generada desde el recurso web";

            var id = 1;

            UserPosts userPosts = _context.UserPosts.Find(id);

            if (userPosts == null)
            {
                var resource = "https://jsonplaceholder.typicode.com/posts";
                var json = new WebClient().DownloadString(resource);

                List<UserPosts> post = JsonConvert.DeserializeObject<List<UserPosts>>(json);
                return View(post);
            }
            else {
                return View(_context.UserPosts.ToList());
            }
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}