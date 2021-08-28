using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalsApi.Models
{
    public class Portals
    {
        public int Id { get; set; }
        [Required]
        [MaxLength (25) ]
        public string Name { get; set; }
        [Required]
        public bool IsLegalAgeRequired { get; set; } = true;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Users> users;
    }
}
