import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './components/register/register.component';
import { LoginComponent } from './components/login/login.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AdminViewClientComponent } from './components/admin-view-client/admin-view-client.component';
import { FormsModule } from '@angular/forms';
import { AdminAddClientComponent } from './components/admin-add-client/admin-add-client.component';
import { ClientDetailsComponent } from './components/client/client-details/client-details.component';
import { ClientDepositComponent } from './components/client/client-deposit/client-deposit.component';
import { ClientWithdrawalsComponent } from './components/client/client-withdrawals/client-withdrawals.component';
import { ClientUpdateComponent } from './components/client/client-update/client-update.component';
import { ClientWithdrawalFormComponent } from './components/client/client-withdrawal-form/client-withdrawal-form.component';
import { ClientDepositFormComponent } from './components/client/client-deposit-form/client-deposit-form.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatDialogModule} from '@angular/material/dialog';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    DashboardComponent,
    AdminViewClientComponent,
    AdminAddClientComponent,
    ClientDetailsComponent,
    ClientDepositComponent,
    ClientWithdrawalsComponent,
    ClientUpdateComponent,
    ClientWithdrawalFormComponent,
    ClientDepositFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MatDialogModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }