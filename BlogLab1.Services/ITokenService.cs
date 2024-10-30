
using BlogLab1.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab1.Services
{
    public interface ITokenService
    {
         string CreateToken(ApplicationUserIdentity user);
    }
}
