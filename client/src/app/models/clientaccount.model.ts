export interface ClientAccount {
    ClientId: number;
    ClientFirstName: string;
    ClientLastName: string;
    ClientJoinDate: Date;
    ClientPassword: string;
    ClientEmail: string;
    ClientPhone: string;
    ClientStreet: string;
    ClientZipCode: string;
    ClientCity: string;
    ClientAccountId: number;
    ClientAccountBalance: string;
    DepositId: number;
    DepositAmount: string;
    WithdrawalId: number;
    WithdrawalAmount: string;
    WithdrawalDate: string;
}