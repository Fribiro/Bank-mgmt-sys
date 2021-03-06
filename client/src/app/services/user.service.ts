import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Account } from '../models/account.model';
import { AddClient } from '../models/addclient.model';
import { ClientAccounts } from '../models/clientaccount.model';
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

  getAllAccounts(): Observable<Account[]> {
    return this.http.get<Account[]>(this.apiBaseUrl + '/api/Account')
  }

  getBankAccountById(aid: string): Observable<Account> {
    return this.http.get<Account>(this.apiBaseUrl + '/api/Account/' + aid)
  }
}
