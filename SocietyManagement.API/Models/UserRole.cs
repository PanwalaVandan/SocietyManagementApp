using Microsoft.AspNetCore.Identity;

namespace SocietyManagement.API.Models
{
    public class UserRole: IdentityUserRole<int>
    {
        public virtual User User { get; set; }

        public virtual Role Role { get; set; }    
    }
}