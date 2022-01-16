using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimurghEngine.API.Entities.CMS;

namespace SimurghEngine.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken (AppUser user);
    }
}