using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Web.Data
{
    public class User:IdentityUser
    {
        //First name, Last name, Email address, Mobile Number

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfjoined { get; set; }
    }
}
