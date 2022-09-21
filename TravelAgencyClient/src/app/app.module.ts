import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './components/login/login.component';
import { MenuComponent } from './components/menu/menu.component';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { FooterComponent } from './components/footer/footer.component';
import { FilterComponent } from './components/filter/filter.component';
import { FlightListComponent } from './components/flight-list/flight-list.component';
import { ShowUpdateComponent } from './components/show-update/show-update.component';
import { CreditCardComponent } from './components/credit-card/credit-card.component';
import { ContactUsComponent } from './components/contact-us/contact-us.component';
import { BookingComponent } from './components/booking/booking.component';
import { AdminMenuComponent } from './components/admin/admin-menu/admin-menu.component';
import { AdminFlightModelComponent } from './components/admin/admin-flight-model/admin-flight-model.component';
import { AdminFlightsComponent } from './components/admin/admin-flights/admin-flights.component';
import { AdminUpdateModelComponent } from './components/admin/admin-update-model/admin-update-model.component';
import { AdminCustomerServiceComponent } from './components/admin/admin-customer-service/admin-customer-service.component';
import { SpinnerOverlayComponent } from './components/spinner-overlay/spinner-overlay.component';
import { ShowDetailsDirective } from './_directives/show-details.directive';
import { PushpinPipe } from './_pipes/pushpin.pipe';
import { MatNativeDateModule, MAT_DATE_LOCALE } from '@angular/material/core';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule, MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatCardModule } from '@angular/material/card';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import {MatRadioModule} from '@angular/material/radio';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatInputModule } from '@angular/material/input';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSelectModule } from '@angular/material/select';
import { MatListModule } from '@angular/material/list';
import { MatTableModule } from '@angular/material/table';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatGridListModule } from '@angular/material/grid-list';
import { TokenStorageService } from './_services/token-storage.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthInterceptor } from './_helpers/auth.interceptor';
import { AuthGuardService } from './_services/auth-guard.service';
import { AuthService } from './_services/auth.service';
import { BoardAdminComponent } from './components/board-admin/board-admin.component';
import { AdminService } from './_services/admin.service';
import { FlightService } from './_services/flight.service';
import { SpinnerOverlayService } from './_services/spinner-overlay.service';
import { UserService } from './_services/user.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { RecaptchaModule,RECAPTCHA_V3_SITE_KEY,RecaptchaFormsModule } from 'ng-recaptcha';




@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    MenuComponent,
    HomeComponent,
    RegisterComponent,
    PageNotFoundComponent,
    FooterComponent,
    FilterComponent,
    FlightListComponent,
    ShowUpdateComponent,
    CreditCardComponent,
    ContactUsComponent,
    BookingComponent,
    AdminMenuComponent,
    AdminFlightModelComponent,
    AdminFlightsComponent,
    AdminUpdateModelComponent,
    AdminCustomerServiceComponent,
    SpinnerOverlayComponent,
    ShowDetailsDirective,
    PushpinPipe,
    BoardAdminComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatButtonModule,
    MatDialogModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatMenuModule,
    MatIconModule,
    MatCardModule,
    MatSidenavModule,
    MatFormFieldModule,
    MatDatepickerModule,
    MatInputModule,MatCheckboxModule,
    MatProgressSpinnerModule,
    MatGridListModule,
    MatTooltipModule,
    MatToolbarModule,
    MatSelectModule,
    MatListModule,
    MatRadioModule,
    MatTableModule,
    HttpClientModule,
    MatAutocompleteModule,
    RouterModule,
    // EditorModule,  
    MatNativeDateModule, 
    // MatMomentDateModule,
    // AngularEditorModule,
    // MomentModule.forRoot({
    //   relativeTimeThresholdOptions: {
    //     'm': 59
    //   }
    // }),
    // FlexLayoutModule ,
    RecaptchaModule,
    RecaptchaFormsModule,
    // ServiceWorkerModule.register('ngsw-worker.js', { enabled: environment.production })
  
  ],
  providers: [
    AuthGuardService, 
    AuthService,
    TokenStorageService,
    AdminService,
    FlightService,
    SpinnerOverlayService,
    UserService,
    { provide: MAT_DIALOG_DATA, useValue: {} },
    { provide: MatDialogRef, useValue: {} },
    {  provide: MAT_DATE_LOCALE, useValue: 'he-IL'},
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true,
   

   },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
