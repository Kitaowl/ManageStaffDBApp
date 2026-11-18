using Microsoft.EntityFrameworkCore;
using ManageStaffDBApp.Model;

namespace ManageStaffDBApp.Data
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }

    public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ManageStaffDBAppDB;Trusted_Connection=True;");
        }
    }
}
