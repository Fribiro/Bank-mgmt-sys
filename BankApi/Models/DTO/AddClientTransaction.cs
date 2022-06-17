namespace BankApi.Models.DTO
{
    public class AddClientTransaction
    {

       public string? TransactionType { get; set; }

        public DateTime TransactionDate { get; set; }

        public string? TransactionAmount { get; set; }

        public Guid BankClients { get; set; }


    }
}