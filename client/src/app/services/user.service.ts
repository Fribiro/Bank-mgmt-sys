import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ClientAccount } from '../models/clientaccount.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  apiBaseUrl = environment.apiBaseUrl

  getAllBankClients(): Observable<ClientAccount[]> {
    return this.http.get<ClientAccount[]>(this.apiBaseUrl + '/api/clientaccount')
  }
}
