namespace BankApi.Models
{
    public class ClientWithdrawals
    {
        public int WithdrawalId { get; set; }

        public string? WithdrawalType { get; set; }

        public string? WithdrawalAmount { get; set; }

        public DateTime WithdrawalDate { get; set; }

        public string? WithdrawalLocatioon { get; set; }
    }
}
