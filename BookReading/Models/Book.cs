using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Razor;

namespace BookReading.Models
{
	public class Book
	{
	    public Book()
	    {
            Reviews = new List<Review>();
	    }

	    public int Id { get; set; }

		[Display(Name = "Название")]
		public string Title { get; set; }

		public string Description { get; set; }

		public string Author { get; set; }

		public int Pages { get; set; }

		public string Genre { get; set; }

		public void Update(Book newBookData)
		{
			Title = newBookData.Title;
			Description = newBookData.Description;
			Author = newBookData.Author;
			Pages = newBookData.Pages;
			Genre = newBookData.Genre;
		}

        public List<Review> Reviews { get; }
	}
}