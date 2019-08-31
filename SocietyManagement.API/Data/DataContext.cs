using Microsoft.EntityFrameworkCore;

namespace SocietyManagement.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}