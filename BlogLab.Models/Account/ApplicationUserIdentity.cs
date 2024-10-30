using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Account
{
    public class ApplicationUserIdentity : IUser<string>
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public int ApplicationUserId { get; set; } 
        public string Username { get; set; }    
        public string NormalizedUsername { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string Fullname { get; set;}
        public string PasswordHash { get; set; }
    }
}
