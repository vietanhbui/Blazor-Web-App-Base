using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppBase.DataAccess
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("RoleId"), Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
