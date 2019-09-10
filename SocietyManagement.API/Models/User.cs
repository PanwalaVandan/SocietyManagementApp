using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SocietyManagement.API.Models
{
    public class User: IdentityUser<int>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}