import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminAddClientComponent } from './components/admin-add-client/admin-add-client.component';
import { AdminViewClientComponent } from './components/admin-view-client/admin-view-client.component';
import { ClientDepositFormComponent } from './components/client/client-deposit-form/client-deposit-form.component';
import { ClientDepositComponent } from './components/client/client-deposit/client-deposit.component';
import { ClientDetailsComponent } from './components/client/client-details/client-details.component';
import { ClientUpdateComponent } from './components/client/client-update/client-update.component';
import { ClientWithdrawalFormComponent } from './components/client/client-withdrawal-form/client-withdrawal-form.component';
import { ClientWithdrawalsComponent } from './components/client/client-withdrawals/client-withdrawals.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';

const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'dashboard',component:DashboardComponent},
  {path:'admin/client/add', component: AdminAddClientComponent},
  {path:'withdraw/:id', component:ClientWithdrawalFormComponent},
  {path:'deposit/:id', component:ClientDepositFormComponent},
  {path:'client-details/:id', component:ClientDetailsComponent},
  {path:'my-deposits/:id', component:ClientDepositComponent},
  {path:'my-withdrawals/:id', component:ClientWithdrawalsComponent},
  {path:'update-profile/:id', component:ClientUpdateComponent},
  {path:'admin/client/:id', component: AdminViewClientComponent},
  {path:'',redirectTo:'login',pathMatch:'full'},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
