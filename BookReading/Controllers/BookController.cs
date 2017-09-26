using System.Linq;
using System.Web.Mvc;
using BookReading.Models;

namespace BookReading.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/

        public ActionResult List()
        {
            return View(BookContext.Instance.Books);
        }    
		
		public ActionResult Details(int id = 0)
		{
			var book = BookContext.Instance.Books.FirstOrDefault(x => x.Id == id);
			
			if (book == null)
				return HttpNotFound();

            return View(book);
        }
		
	    public ActionResult Edit(int id = 0)
	    {
			var book = BookContext.Instance.Books.FirstOrDefault(x => x.Id == id);

		    if (book == null)
			    return HttpNotFound();

		    return View(book);
	    }

		[HttpPost]
	    public ActionResult Edit(Book editBook)
		{
			Book first = null;
			foreach (var x in BookContext.Instance.Books)
			{
				if (x.Id == editBook.Id)
				{
					first = x;
					break;
				}
			}

			if (first == null)
				return HttpNotFound();
			
			first.Update(editBook);

			return View(editBook);
		}

    }
}
