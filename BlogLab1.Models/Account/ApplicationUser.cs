﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab1.Models.Account
{
    public class ApplicationUser
    {
        public int ApplicationUserId { get; set; }
        public string UserName { get; set; }
       
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
       
        public string PhoneNumberConfirmed { get; set; }
        public string EmailConfirmed { get; set; }
        = string.Empty;
        public string Fax { get; set; }
        = string.Empty;

    }
}
