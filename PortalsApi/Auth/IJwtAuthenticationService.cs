using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalsApi.Auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string username, string password);
    }
}
