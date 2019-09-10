using System.Threading.Tasks;
using SocietyManagement.API.Models;

namespace SocietyManagement.API.Data.Authentication
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);

         Task<User> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}