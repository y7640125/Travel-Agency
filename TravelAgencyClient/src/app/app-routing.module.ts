import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminCustomerServiceComponent } from './components/admin/admin-customer-service/admin-customer-service.component';
import { AdminFlightsComponent } from './components/admin/admin-flights/admin-flights.component';
import { AdminMenuComponent } from './components/admin/admin-menu/admin-menu.component';
import { AdminUpdateModelComponent } from './components/admin/admin-update-model/admin-update-model.component';
import { BoardAdminComponent } from './components/board-admin/board-admin.component';
import { BookingComponent } from './components/booking/booking.component';
import { ContactUsComponent } from './components/contact-us/contact-us.component';
import { FilterComponent } from './components/filter/filter.component';
import { FlightListComponent } from './components/flight-list/flight-list.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { RegisterComponent } from './components/register/register.component';
import { AuthGuardService } from './_services/auth-guard.service';

const routes: Routes = [
   {path: '', component: HomeComponent},
//  {path:'',redirectTo:'/Home',pathMatch:'full'},
 {path:"home",component:HomeComponent},
 {path:"login",component:LoginComponent},
 {path:"register",component:RegisterComponent},
 {path:"us",component:ContactUsComponent},
 {path:"booking",component:BookingComponent},
 {path:"**",component:PageNotFoundComponent},
 {path: 'admin',
  canActivate: [AuthGuardService],
  component: BoardAdminComponent,
  children: [
    {path: '',redirectTo:'admin-flights', pathMatch: 'full' },
    {path: 'admin-flights',component: AdminFlightsComponent },
    {path: 'admin-customer',component: AdminCustomerServiceComponent },
    {path: 'update',component: AdminUpdateModelComponent,},
    {path: '',outlet: 'menu',component: AdminMenuComponent,},
  ],
},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
