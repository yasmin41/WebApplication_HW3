using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Context
{
    public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> contextOptions) : DbContext(contextOptions)
    {
        //code - Approach
        public required DbSet<Person> People { get; set; }
    }
}
