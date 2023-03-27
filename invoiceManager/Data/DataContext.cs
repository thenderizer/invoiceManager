using invoiceManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace invoiceManager.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {

        }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Invoice> Invoices { get;set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
