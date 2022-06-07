import { Component, OnInit } from '@angular/core';
import { ClientAccount } from 'src/app/models/clientaccount.model';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private userService: UserService) { }

  bankClients: ClientAccount[] = [];

  ngOnInit(): void {
    this.userService.getAllBankClients()
    .subscribe(
      response => {
        this.bankClients = response;
        
      }
    )
  }

}
