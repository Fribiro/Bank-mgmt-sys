import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClientAccounts } from 'src/app/models/clientaccount.model';
import { UpdateClient } from 'src/app/models/updateclient.model';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-client-deposit-form',
  templateUrl: './client-deposit-form.component.html',
  styleUrls: ['./client-deposit-form.component.css']
})
export class ClientDepositFormComponent implements OnInit {

  constructor(private route: ActivatedRoute, private userService: UserService ) { }

  bankClient: ClientAccounts | undefined;
  

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
