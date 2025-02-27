using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<TaskEntry> Tasks { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            :base(options)
        {

        }
    }
}