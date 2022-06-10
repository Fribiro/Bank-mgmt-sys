using System.ComponentModel.DataAnnotations.Schema;
// using System.ComponentModel.DataAnnotations;
namespace BankApi.Models.Entity
{
    public class AccountDetails
    {
        public Guid Id { get; set; }

        public string? AccountType { get; set; }

        public string? AccountBalance { get; set; }

        [ForeignKey("BankClient")]
        // public int ClientId { get; set; }
        public virtual BankClients BankClients { get; set; }
    }
}