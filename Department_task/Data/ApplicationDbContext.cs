using Department_task.Models;
using Microsoft.EntityFrameworkCore;

namespace Department_task.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=db4799.public.databaseasp.net ; Database=db4799; User Id=db4799; Password=********; Encrypt=False; MultipleActiveResultSets=True;");
        }
    }
}
