using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        private ReviewSqlDAO reviewSqlDAO;

        public HomeController(ReviewSqlDAO reviewSqlDAO)
        {
            this.reviewSqlDAO = reviewSqlDAO;
        }

        // GET: Home
        public ActionResult Index()
        {
            List<Review> reviews = reviewSqlDAO.GetAllReviews();
            return View(reviews);
        }        

        [HttpGet]
        public IActionResult NewReview()
        {
            Review review = new Review();
            return View(review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewReview(Review review)
        {
            review.ReviewDate = DateTime.Now;
            reviewSqlDAO.SaveReview(review);

            return RedirectToAction("index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
