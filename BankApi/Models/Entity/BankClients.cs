using System.ComponentModel.DataAnnotations;
using BankApi.Models.Entity;
using Microsoft.AspNetCore.Identity;

namespace BankApi.Models
{
    public class BankClients : IdentityUser
    {
        
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public List<Transactions> Transactions { get; set; }

    }
}