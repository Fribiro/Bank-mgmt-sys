import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Account } from '../models/account.model';
import { AddClient } from '../models/addclient.model';
import { AddTransaction } from '../models/addtransaction.model';
import { ClientAccounts } from '../models/clientaccount.model';
import { ClientTransactions } from '../models/clienttransactions.model';
import { UpdateClient } from '../models/updateclient.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  apiBaseUrl = environment.apiBaseUrl

  getAllBankClients(): Observable<ClientAccounts[]> {
    return this.http.get<ClientAccounts[]>(this.apiBaseUrl + '/api/BankClient')
  }

  getBankClientById(id: string): Observable<ClientAccounts> {
    return this.http.get<ClientAccounts>(this.apiBaseUrl + '/api/BankClient/' + id)
  }

  updateBankClient(id: string | undefined, updateClient: UpdateClient): Observable<ClientAccounts> {
    return this.http.put<ClientAccounts>(this.apiBaseUrl + '/api/BankClient/' + id, updateClient)
  }

  addBankClient(addClient: AddClient): Observable<ClientAccounts> {
    return this.http.post<ClientAccounts>(this.apiBaseUrl + '/api/BankClient', addClient)
  }

  deleteBankClient(id: string | undefined): Observable<ClientAccounts> {
    return this.http.delete<ClientAccounts>(this.apiBaseUrl + '/api/BankClient/' + id)
  }
  
  getAllClientDeposits(id: string): Observable<ClientTransactions[]> {
    return this.http.get<ClientTransactions[]>(this.apiBaseUrl + '/api/BankClient/my-transaction/' + id)
  }

  getAllClientWithdrawals(id: string): Observable<ClientTransactions[]> {
    return this.http.get<ClientTransactions[]>(this.apiBaseUrl + '/api/BankClient/transaction/' + id)
  }

  addClientTransaction(id: string | undefined, addTransaction: AddTransaction): Observable<ClientTransactions> {
    return this.http.post<ClientTransactions>(this.apiBaseUrl + '/api/BankClient/transaction/' + id, addTransaction)
  }
}
