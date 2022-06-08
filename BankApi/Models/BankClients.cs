using System.ComponentModel.DataAnnotations;

namespace BankApi.Models
{
    public class BankClients
    {
        [Key]
        public Guid ClientId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }
    }
}