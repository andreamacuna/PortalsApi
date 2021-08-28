using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalsApi.Models
{
    public class Comments
    {
        public int Id { get; set; }
        [MaxLength (25)]
        [Required]
        public string Title { get; set; }
        [MaxLength(255)]
        [Required]
        public string Content { get; set; }
        [Required]
        public int UserId { get; set; }
        public Users Users { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
