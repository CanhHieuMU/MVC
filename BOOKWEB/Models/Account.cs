using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace BOOKWEB.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Usernames { get; set; }
        public string Passwords { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public CategoryRole CategoryRoleID { get; set; }

    }
}
