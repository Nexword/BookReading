using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookReading.Models
{
	public class Review
	{
		public int Id { get; set; }
		
		[Display(Name = "Автор")]
		public int AuthorId { get; set; }

		public int BookId { get; set; }
		
		[Required (ErrorMessage = "Поле Отзыв обязательно для заполнения")]
		[Display(Name = "Отзыв")]
		public string Text { get; set; }
	}
}