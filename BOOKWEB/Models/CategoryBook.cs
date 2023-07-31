using System.ComponentModel.DataAnnotations;

namespace BOOKWEB.Models
{
    public class CategoryBook
    {
        public CategoryBook()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int CategoryBookId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
