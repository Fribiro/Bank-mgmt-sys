export interface AddTransaction {
    transactionType: string | undefined;
    transactionDate: Date | undefined;
    transactionAmount: string | undefined;
    accountBalance: number | undefined;
    bankClients: string | undefined;
}