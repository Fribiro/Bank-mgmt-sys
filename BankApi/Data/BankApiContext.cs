using BankApi.Models.Entity;
using Microsoft.EntityFrameworkCore;
namespace BankApi.Models
    
    {
        public class BankApiContext : DbContext 
        {

            public BankApiContext (DbContextOptions<BankApiContext> options) : base (options) { }

            public DbSet<BankClients> BankClients { get; set; }

            public  DbSet<AccountDetails> AccountDetails { get; set; } 

            public DbSet<Transactions> Transactions { get; set; }
        }
    }