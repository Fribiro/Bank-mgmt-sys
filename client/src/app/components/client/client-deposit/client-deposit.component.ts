import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClientAccounts } from 'src/app/models/clientaccount.model';
import { ClientTransactions } from 'src/app/models/clienttransactions.model';
import { UpdateClient } from 'src/app/models/updateclient.model';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-client-deposit',
  templateUrl: './client-deposit.component.html',
  styleUrls: ['./client-deposit.component.css']
})
export class ClientDepositComponent implements OnInit {

  constructor(private route: ActivatedRoute, private userService: UserService ) { }

  bankClient: ClientAccounts | undefined;
  clientTransaction: ClientTransactions[] = [];
  

  ngOnInit(): void {
    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');

        if (id) {
          this.userService.getBankClientById(id)
          .subscribe(
            response => {
              this.bankClient = response;
              //console.log(response);
              
            }
          )
        }
      }
    )

    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');

        if (id) {
          this.userService.getAllClientDeposits(id)
          .subscribe(
            response => {
              this.clientTransaction[0] = response[0];
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
