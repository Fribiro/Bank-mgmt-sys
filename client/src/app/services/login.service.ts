import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ClientAccounts } from '../models/clientaccount.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http: HttpClient) { }

  apiBaseUrl = environment.apiBaseUrl

  getAllBankClients(): Observable<ClientAccounts[]> {
    return this.http.get<ClientAccounts[]>(this.apiBaseUrl + '/api/clientaccount')
  }
}
