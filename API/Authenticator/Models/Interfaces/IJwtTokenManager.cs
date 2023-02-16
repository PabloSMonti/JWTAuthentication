using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authenticator.Models.Interfaces
{
    public interface IJwtTokenManager
    {
        public string Authenticate(string userName,string pass);
    }
}