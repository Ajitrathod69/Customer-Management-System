using Microsoft.EntityFrameworkCore;

namespace Customer_Management_System.Models
{
    public class EFDBhandle:DbContext
    {
        public string conn= "Server=DESKTOP-R87BCPP;Database=Customer_Management_System_DB;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
        {
            optionsB.UseSqlServer(conn);
        }

        public DbSet<Customer> Customers { get; set; }
       
    }

}
