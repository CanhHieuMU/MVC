using System.ComponentModel.DataAnnotations;

namespace BOOKWEB.Models
{
    public class Repository
    {
        public Repository()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int RepositoryID { get; set; }
        [Required]
        public string RepositoryName { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Book> Books { get; set; }


    }
}
