import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { TokenStorageService } from './token-storage.service';

const AUTH_API = environment.api + '/auth/';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' ,
  'Access-Control-Allow-Origin' : '*',  'Access-Control-Allow-Methods':'GET,PUT,POST,DELETE,PATCH,OPTIONS'}),
};

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(
    private http: HttpClient,
    private tokenStorage: TokenStorageService
  ) {}
  login(credentials:any): Observable<any> {
    return this.http.post(
      AUTH_API + 'signin',
      {
        userName: credentials.userName,
        password: credentials.password,
      },
      httpOptions
     );
  }
  disableUser(credentials:any): Observable<any> {
    return this.http.post(
      AUTH_API + 'disableUser',
      {
        userName: credentials.userName
      },
      httpOptions
    );
  }
 
  isAuth() {
    return this.tokenStorage.getToken();
  }
}
