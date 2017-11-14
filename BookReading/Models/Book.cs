using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Razor;
using LinqToDB.Mapping;

namespace BookReading.Models
{
    [Table]
	public class Book
	{
	    public Book()
	    {
            Reviews = new List<Review>();
	    }

        [PrimaryKey, Identity]
	    public int Id { get; set; }

		[Display(Name = "Название"), Column]
		public string Title { get; set; }

        [Column]
		public string Description { get; set; }

	    [Column]
        public string Author { get; set; }

	    [Column]
        public int Pages { get; set; }

	    [Column]
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