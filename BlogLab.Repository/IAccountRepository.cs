using BlogLab.Models.Account;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public interface IAccountRepository
    {
          Task<IdentityResult> CreateAsync(ApplicationUserIdentity user,CancellationToken cancellationToken);

         Task<ApplicationUserIdentity> GetByUsernameAsync(string normalizedUsername, CancellationToken cancellationToken);

    }
}
