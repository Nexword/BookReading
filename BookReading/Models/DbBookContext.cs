using System.Collections.Generic;

namespace BookReading.Models
{
    public class DbBookContext : IBookContext
    {
        public void AddBook(Book newBook)
        {
            throw new System.NotImplementedException();
        }

        public void AddReview(Review newReview)
        {
            throw new System.NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Book GetBook(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public Book Update(Book newBookData)
        {
            var book = GetBook(newBookData.Id);
            if (book == null)
                return null;
            throw new System.NotImplementedException();

            book.Update(newBookData);
	        return book;
        }
    }
}