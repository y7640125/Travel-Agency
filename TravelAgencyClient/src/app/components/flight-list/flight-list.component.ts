import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Flight } from 'src/app/_models/flight.model';
import { FlightService } from 'src/app/_services/flight.service';
import { UserService } from 'src/app/_services/user.service';

@Component({
  selector: 'app-flight-list',
  templateUrl: './flight-list.component.html',
  styleUrls: ['./flight-list.component.less']
})
export class FlightListComponent implements OnInit {

  constructor(
    private router: Router,
    private flightServer: FlightService,
    private user:UserService
  ) { }

  @Input() flights!:Flight[];
  
  ngOnInit() {}

  booking(flight: Flight): void {
    this.router.navigate(["/booking"])
  }

}
