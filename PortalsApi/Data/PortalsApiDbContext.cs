using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PortalsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalsApi.Data
{
    public class PortalsApiDbContext: DbContext
    {

        public PortalsApiDbContext(DbContextOptions<PortalsApiDbContext> options) : base(options)
        {

        }

    
        public DbSet<Portals> Portals { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Comments> Comments { get; set; }

      

    }
}
