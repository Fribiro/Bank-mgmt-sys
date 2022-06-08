using Microsoft.EntityFrameworkCore;
namespace BankApi.Models 
    
    {
        public class BankApiContext : DbContext 
        {

            public BankApiContext (DbContextOptions<BankApiContext> options) : base (options) { }

            public DbSet<BankClients> BankClients { get; set; }
        }
    }