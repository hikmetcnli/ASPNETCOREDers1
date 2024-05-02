using System.ComponentModel.DataAnnotations;

namespace Ders1.Models
{
	public class Book
	{
        [Key]
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Writer { get; set; }

        public int Price { get; set; }
    }
}
