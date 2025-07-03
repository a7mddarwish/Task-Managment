using Microsoft.EntityFrameworkCore;

namespace TaskMS.AccessData.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }



    }
}
