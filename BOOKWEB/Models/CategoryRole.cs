using System.ComponentModel.DataAnnotations;

namespace BOOKWEB.Models
{
    public class CategoryRole
    {
        [Key]
        public int CategoryRoleId { get; set; }
        [Required]
        public string RoleName { get; set; }

    }
}
