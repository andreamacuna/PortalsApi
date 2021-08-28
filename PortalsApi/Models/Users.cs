using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalsApi.Models
{
    public class Users
    {
        public int Id { get; set; }
        [MaxLength (30)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(15)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(8)]
        [Required]
        public string NickName { get; set; }
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }
        [MaxLength(255)]
        [Required]
        public string Password { get; set; }
        [Required]
        public int PortalId { get; set; }
        public Portals Portals { get; set; }
        [Required]
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public bool IsLegalAge { get; set; } = false;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }
    }
}
