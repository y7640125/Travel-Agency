import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Airline, Country, Flight } from '../_models/flight.model';

const F_API = environment.api + '/Flight/';
const L_API = environment.api + '/LookUp/';

@Injectable({
  providedIn: 'root'
})
export class FlightService {

  constructor(private http: HttpClient) { }

  getAllFlights(): Observable<Flight[]> {
    return this.http.get<Flight[]>(F_API + 'Flights');
  }
  
  filterFlights(countryId: any, departureDate: any, returnDate: any): Observable<Flight[]> {
    return this.http.get<Flight[]>(F_API + `filter/${countryId}/${departureDate}/${returnDate}`);
  }
  saveFlight(flight:Flight,flightId?:number) :  Observable<boolean>{  
    if(flightId===undefined){
      return this.http.post<boolean>(F_API + 'add',flight);
    }
         return this.http.put<boolean>(F_API +`update/${flightId}`,flight);
      }

      getFlightById(flightId:number): Observable<Flight> {
        return this.http.get<Flight>(F_API +`FlightById/${flightId}`);
      }

      getAllAirlines(): Observable<Airline[]> {
        return this.http.get<Airline[]>(L_API + 'Airlines');
      }

      getAllCountries(): Observable<Country[]> {
        return this.http.get<Country[]>(L_API + 'Countries');
      }
      
  deleteFlight(flightId: number) :  Observable<boolean>{
    return this.http.delete<boolean>(F_API + 'delete/'+ flightId);
  }
}
