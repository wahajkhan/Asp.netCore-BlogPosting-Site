using Asp.netCore_BlogPosting_Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore_BlogPosting_Site.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogDBContext db;

        public BlogController(BlogDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index(int page=0)
        {
            var pagesize = 3;
            var totalPost = db.Post.Count();
            var totalPage = totalPost / pagesize;
            var previousPage = page - 1;
            var nextPage = page + 1;

            ViewBag.PreviousPage = previousPage;
            ViewBag.HasPreviousPage = previousPage >= 0;
            ViewBag.NextPage = nextPage;
            ViewBag.HasNextPage = nextPage <= totalPage;



            var post = (from x in 
                            db.Post.
                            OrderByDescending(x=>x.Posted).
                            Skip(pagesize * page).
                            Take(pagesize)
                        .ToList()
                        select new Post()
                        {
                            ID = x.ID,
                            Title=x.Title,
                            Author = x.Author,
                            Posted = x.Posted,
                            Body = x.Body.Substring(0,100)+"...."
                        }).ToList();

            if (Request.Headers["X-Requested-With"]=="XMLHttpRequest")
            {
                return PartialView("_Partial_Blog", post);
            }


            return View(post);
        }

        public IActionResult Post(int id)
        {

            var post = db.Post.Where(x => x.ID == id).ToList();
            
            return View(post);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                post.Author = User.Identity.Name;
                post.Posted = DateTime.Now;

                db.Add(post);
                db.SaveChanges();

                ViewBag.Status = "<p class='text-success'>Your blog Posted successfully, after approval you will get email notification Thank you</p>";
                return View();
            }
            return View();
        }
    }
}
