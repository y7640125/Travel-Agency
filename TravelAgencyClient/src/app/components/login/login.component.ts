import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from 'src/app/_models/user.model';
import { AuthService } from 'src/app/_services/auth.service';
import { TokenStorageService } from 'src/app/_services/token-storage.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.less']
})
export class LoginComponent implements OnInit {

  hide = true;
  isLoggedIn = false;
  isLoginFailed = false;
  errorMessage = '';
  user: User | undefined;
  message: string | undefined;
  iCountTrial = 0;
  constructor(
    private authService: AuthService,
    private tokenStorage: TokenStorageService,
    private fb: FormBuilder,
    private router: Router
  ) { }

  form = this.fb.group({
    userName: this.fb.control('', [Validators.required]),
    recaptchaReactive: new FormControl(null, [Validators.required]),
    password: this.fb.control('', [
      Validators.required,
      Validators.pattern(
        '(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$@$!%*?&])[A-Za-zd$@$!%*?&].{7,}'
      ),
    ]),
  });

  ngOnInit(): void {
    if (this.tokenStorage.getToken()) {
      this.isLoggedIn = true;
      this.user = this.tokenStorage.getUser().user;
      if (this.user?.roleId === 1) {
        this.router.navigateByUrl('/admin');
      }
    }
  }
  login(): void {
    const self = this;
    this.authService.login(this.form.value).subscribe(
      (data) => {
        if (data.user.isDisable) {
          this.message = "המשתמש " + this.form.value.userName + " נחסם " + "פנה למנהל המערכת ";
        }
        else {
          this.tokenStorage.saveToken(data.accessToken);
          this.tokenStorage.saveUser(data);

          this.isLoggedIn = true;
          this.user = <User>this.tokenStorage.getUser().user;
          if (this.user.roleId === 1) {
            this.router.navigateByUrl('/admin');
          } 
        }
      },
      (err) => {
        self.iCountTrial++;
        if (self.iCountTrial >= 5) {
          if (self.iCountTrial >= 10) {
            self.authService.disableUser(self.form.value).subscribe(
              (data) => {
                self.message = "המשתמש " + self.form.value.userName + " נחסם";

              });
          }
          else {
            self.message =
              ' בוצעו ' +
              self.iCountTrial +
              'נסיונות שגויים מתוך 10 נסיונות אפשריים, המערכת תחסום את המשתמש  ';
          }
        } else {
          self.message = err.error.message;
        }
      }
    );
  }

}
