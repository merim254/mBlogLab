


using BlogLab1.Models.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogLab1.Repository
{
    public interface IAccountRepository
    {
          Task<IdentityResult> CreateAsync(ApplicationUserIdentity user,CancellationToken cancellationToken);

         Task<ApplicationUserIdentity> GetByUsernameAsync(string normalizedUsername, CancellationToken cancellationToken);

        Task<ApplicationUserIdentity> GetByIdAsync(string userId, CancellationToken cancellationToken);
        Task<ApplicationUserIdentity> GetByEmailAsync(string normalizedEmail, CancellationToken cancellationToken); // Add this method

    }
}
