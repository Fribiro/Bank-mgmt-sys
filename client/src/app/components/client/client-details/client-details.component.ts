import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Account } from 'src/app/models/account.model';
import { ClientAccounts } from 'src/app/models/clientaccount.model';
import { UpdateClient } from 'src/app/models/updateclient.model';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-client-details',
  templateUrl: './client-details.component.html',
  styleUrls: ['./client-details.component.css']
})
export class ClientDetailsComponent implements OnInit {

  constructor(private route: ActivatedRoute, private userService: UserService ) { }

  bankClient: ClientAccounts | undefined;
  account: Account | undefined;
  

  ngOnInit(): void {
    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');

        if (id) {
          this.userService.getBankClientById(id)
          .subscribe(
            response => {
              this.bankClient = response;
              console.log(response);
              
            
              
            }
          )
        }

        
      }
    )
  }

  onSubmit(): void {

    const updateClient: UpdateClient = {
      firstName: this.bankClient?.firstName,
      lastName: this.bankClient?.lastName,
      email: this.bankClient?.email,
      phone: this.bankClient?.phone
    }

    this.userService.updateBankClient(this.bankClient?.id, updateClient)
    .subscribe(
      response => {
        alert('Success')
      }
    )
  }



}
