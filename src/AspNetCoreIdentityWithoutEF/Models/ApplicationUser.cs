using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace AspNetCoreIdentityWithoutEF.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : ClaimsIdentity
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public bool TwoFactorEnabled { get; set; }
    }

    public class ApplicationRole
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
