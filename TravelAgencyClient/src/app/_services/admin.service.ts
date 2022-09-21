import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Message } from '../_models/message.model';
import { Update } from '../_models/update.model';

const U_API = environment.api + '/Update/';
const M_API = environment.api + '/Message/';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  constructor(private http: HttpClient) { }

  getAllUpdates(): Observable<Update[]> {
    return this.http.get<Update[]>(U_API + 'Updates');
  }

  sendMessage(message:Message): Observable<boolean>{
    return this.http.post<boolean>(M_API + 'add',message)
  }
}
