using common.portal.com.Entity;
using Microsoft.EntityFrameworkCore;

namespace dataccess.portal.com.Context
{
    public class PortalDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=PortalCaseDb;Trusted_Connection=True;");

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
