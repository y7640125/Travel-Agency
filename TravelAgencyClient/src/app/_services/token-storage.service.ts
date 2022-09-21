import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

const TOKEN_KEY = 'auth-token';
const USER_KEY = 'auth-user';
@Injectable({
  providedIn: 'root'
})
export class TokenStorageService {
public userChanged: Subject<string> = new Subject<string>();
  constructor() { }
  signOut(): void {
    window.sessionStorage.clear();
    this.userChanged.next("");
  }

  public saveToken(token: string): void {
    window.sessionStorage.removeItem(TOKEN_KEY);
    window.sessionStorage.setItem(TOKEN_KEY, token);
  
  }

  public getToken(): any {
    return sessionStorage.getItem(TOKEN_KEY);
  }

  public saveUser(user:any): void {
    window.sessionStorage.removeItem(USER_KEY);
    window.sessionStorage.setItem(USER_KEY, JSON.stringify(user));
    this.userChanged.next(USER_KEY);
  }

  public getUser():any {
    return JSON.parse(sessionStorage.getItem(USER_KEY) as string);
  }
}