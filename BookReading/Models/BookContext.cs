using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinqToDB;
using LinqToDB.Data;

namespace BookReading.Models
{
	public class BookContext : IBookContext
    {
		private static readonly BookContext _instance = new BookContext();

		public static IBookContext Instance
		{
			get { return _instance; }
		}

		private List<Book> Books = new List<Book>();

		private List<Review> Reviews = new List<Review>();

	    public Book GetBook(int bookId)
	    {
	        return Books.FirstOrDefault(x => x.Id == bookId);
	    }

	    public Book Update(Book newBookData)
	    {
	        throw new NotImplementedException();
	    }

        public List<Book> GetAll()
	    {
	        return Books;
	    }

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