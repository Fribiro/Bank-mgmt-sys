using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models.Entity
{
    public class Transactions
    {
        public Guid Id { get; set; }

        public string? TransactionType { get; set; }

        public DateTime TransactionDate { get; set; }

        public string? TransactionAmount { get; set; }

        public int? AccountBalance { get; set; }

        public BankClients BankClients { get; set; }
    }
}