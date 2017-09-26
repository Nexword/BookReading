using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookReading.Models
{
	public class BookContext
	{
		private static readonly BookContext _intstance = new BookContext();

		public static BookContext Instance
		{
			get { return _intstance; }
		}


//		public IEnumerable<Book> Books
//		{
//			get { return _books; }
//		}
//
//		public IEnumerable<Review> Reviews
//		{
//			get { return _reviews; }
//		}

		public List<Book> Books = new List<Book>();

		public List<Review> Reviews = new List<Review>();

		public void AddBook(Book newBook)
		{
			_bookId++;
			newBook.Id = _bookId;
			Books.Add(newBook);
		}

		public void AddReview(Review newReview)
		{
			_reviewId++;
			newReview.Id = _reviewId;
			Reviews.Add(newReview);
		}

		private static int _bookId;

		private static int _reviewId;

		private BookContext()
		{
			Book book = new Book()
			{
				Author = "King",
				Description = "It is scary story",
				Genre = "horror",
				Id = 0,
				Pages = 200,
				Title = "It"
			};			
			
			Book book1 = new Book()
			{
				Author = "King1",
				Description = "It is scary story2",
				Genre = "horror3",
				Id = 1,
				Pages = 800,
				Title = "It2"
			};

			Books.AddRange(new List<Book>(){book,book1});

			Review review = new Review()
			{
				Id = 1,
				AuthorId = 1,
				BookId = 0,
				Text = "Good choice!"
			};

			Reviews.Add(review);
			_bookId = 1;
			_reviewId = 1;

		}
	}
}