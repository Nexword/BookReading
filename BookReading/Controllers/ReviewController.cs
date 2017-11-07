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
        private IBookContext _bookContext;

        public ReviewController() : this(BookContext.Instance)
        {
        }

        public ReviewController(IBookContext bookContext)
        {
            if (bookContext == null)
                throw new ArgumentNullException();
            _bookContext = bookContext;
        }
        //
        // GET: /Review/

        public ActionResult Create(int bookId)
        {
	        if (_bookContext.GetBook(bookId) == null)
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
