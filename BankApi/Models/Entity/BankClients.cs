using System.ComponentModel.DataAnnotations;
using BankApi.Models.Entity;

namespace BankApi.Models
{
    public class BankClients
    {
        
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public List<AccountDetails> AccountDetails { get; set; }

    }
}