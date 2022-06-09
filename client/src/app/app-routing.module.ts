import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminAddClientComponent } from './components/admin-add-client/admin-add-client.component';
import { AdminViewClientComponent } from './components/admin-view-client/admin-view-client.component';
import { ClientDetailsComponent } from './components/client/client-details/client-details.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';

const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'dashboard',component:DashboardComponent},
  {path:'admin/client/add', component: AdminAddClientComponent},
  {path:'client-details/:id', component:ClientDetailsComponent},
  {path:'admin/client/:id', component: AdminViewClientComponent},
  {path:'',redirectTo:'login',pathMatch:'full'},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
