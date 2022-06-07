using System.ComponentModel.DataAnnotations;

namespace BankApi.Models
{
    public class BankClients
    {
        [Key]
        public int ClientId { get; set; }

        public string? ClientFirstName { get; set; }

        public string? ClientLastName { get; set; }

        public DateTime ClientJoinDate { get; set; }

        public string? ClientPassword { get; set; }

        public string? ClientEmail { get; set; } 

        public string? ClientPhone { get; set; }

        public string? ClientStreet { get; set; }

        public string? ClientZipCode { get; set; }

        public string? ClientCity { get; set; }

        public int ClientAccountId { get; set; }

        public string? ClientAccountBalance { get; set; }

        public int DepositId { get; set; }

        public string? DepositAmount { get; set; }

        public int WithdrawalId { get; set; }

        public string? WithdrawalAmount { get; set; } 

        public DateTime WithdrawalDate { get; set; }


    }
}
