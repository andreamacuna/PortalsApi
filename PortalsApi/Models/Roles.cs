using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalsApi.Models
{
    public class Roles
    {
        public int Id { get; set; }
        [MaxLength (25)]
        [Required]
        public string Name { get; set; }
    }
}
