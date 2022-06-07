using BankApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Data
{
    public class BankApiDbContext : DbContext
    {
        public BankApiDbContext(DbContextOptions<BankApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        //DbSet
        public DbSet<BankClients> BankClients { get; set; }

        public DbSet<ClientAccount> ClientAccounts { get; set; }

        public DbSet<ClientDeposits> ClientDeposits { get; set; }

        public DbSet<ClientWithdrawals> ClientWithdrawals { get; set; }

    }
}
