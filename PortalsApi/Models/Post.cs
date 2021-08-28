using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalsApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        [MaxLength (255)]
        [Required]
        public string Description { get; set; }
        [Required]
        public int PortalId { get; set; }
        public Portals Portals { get; set; }

    }
}
