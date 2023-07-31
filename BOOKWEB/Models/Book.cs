using System.ComponentModel.DataAnnotations;

namespace BOOKWEB.Models
{
    public class Book
    {
        public Book()
        {
            this.CategoryBooks = new HashSet<CategoryBook>();
            this.Repositories = new HashSet<Repository>();
        }

        [Key]
        public int BookId { get; set; }
        [Required]
        public string Name { get; set; }
        public string InformationBook { get; set; }
        public DateTime DatePublic { get; set; }
        public virtual ICollection<CategoryBook> CategoryBooks { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
    }
}
