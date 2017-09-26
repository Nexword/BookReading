using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookReading.Models;

namespace BookReading.Controllers
{
    public class ReviewController : Controller
    {
        //
        // GET: /Review/

        public ActionResult Create(int bookId)
        {
	        if (BookContext.Instance.Books.All(x => x.Id != bookId))
		        return HttpNotFound();
			
			var review = new Review(){BookId = bookId};
            
			return View(review);
        }

		[HttpPost]
	    public ActionResult Create(Review review)
	    {
		    if (ModelState.IsValid)
		    {
			    BookContext.Instance.AddReview(review);
		    }
		    else
		    {
			    ModelState.AddModelError("Create", "Something wrong!");
		    }
		    return RedirectToAction("Details", "Book", new { id = review.BookId });
	    }

    }
}
