using System.ComponentModel.DataAnnotations;

namespace AutoFlow.Web.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}