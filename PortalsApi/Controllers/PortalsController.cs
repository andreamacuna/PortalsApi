using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalsApi.Data;
using PortalsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortalsController : ControllerBase
    {
        private readonly PortalsApiDbContext dbContext;

        public PortalsController(PortalsApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost("RegisterUser")]
        public async Task<IActionResult> RegisterUser (int portalId, Users users)
        {
            var portal = await dbContext.Portals.FindAsync(portalId);
            if (portal.IsLegalAgeRequired && users.IsLegalAge)
            {
                var user = dbContext.Users.Add(users);
                return Ok(user);
            }
            else if (!portal.IsLegalAgeRequired)
            {
                var user = dbContext.Users.Add(users);
                return Ok(user);
            }
            return BadRequest();
        }
        [HttpPost("LoginUser")]
        public async Task<IActionResult> LoginUser (string email, string password )
        {
            var user = dbContext.Users.Where(u => u.Email == email).First();
            if (user != null )
            {
                if (user.Password == password && user.DeletedAt != null)
                {
                    return Ok();
                }

            }
            return BadRequest();
        }
    }
}
