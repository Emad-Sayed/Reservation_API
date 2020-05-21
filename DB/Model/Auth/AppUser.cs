using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Model.Auth
{
    public class AppUser : IdentityUser
    {
        public string Confirmation_Code { get; set; }
    }
}
