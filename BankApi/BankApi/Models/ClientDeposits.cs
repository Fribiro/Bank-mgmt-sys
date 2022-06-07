namespace BankApi.Models
{
    public class ClientDeposits
    {
        public int DepositId { get; set; }

        public string? DepositType { get; set; }

        public string? DepositAmount { get; set; }

        public DateTime DepositDate { get; set; }

        public string? DepositLocatioon { get; set; }
    }
}
