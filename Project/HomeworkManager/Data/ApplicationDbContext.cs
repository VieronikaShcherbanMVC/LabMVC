using Microsoft.EntityFrameworkCore;
using HomeworkManager.Models;

namespace HomeworkManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HomeworkTask> HomeworkTasks { get; set; }
    }
}