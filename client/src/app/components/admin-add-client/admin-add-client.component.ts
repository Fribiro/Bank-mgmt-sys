import { Component, OnInit } from '@angular/core';
import { AddClient } from 'src/app/models/addclient.model';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-admin-add-client',
  templateUrl: './admin-add-client.component.html',
  styleUrls: ['./admin-add-client.component.css']
})
export class AdminAddClientComponent implements OnInit {

  constructor(private userService: UserService  ) { }

  addClient: AddClient = {
    firstName: '',
    lastName: '',
    email: '',
    phone: ''
  }

  ngOnInit(): void {
  }

  onSubmit(): void {
    this.userService.addBankClient(this.addClient)
    .subscribe(
      response => {
        alert('Success')
      }
    )
  }

}
