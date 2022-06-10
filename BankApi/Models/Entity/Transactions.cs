using System.ComponentModel.DataAnnotations.Schema;

namespace BankApi.Models.Entity
{
    public class Transactions
    {
        public Guid Id { get; set; }

        public string? TransactionType { get; set; }

        public DateTime TransactionDate { get; set; }

        public string? TransactionAmount { get; set; }

        public string? AccountBalance { get; set; }

        // [ForeignKey("AccountDetails")]
        // public virtual AccountDetails AccountDetails { get; set; }
    }
}