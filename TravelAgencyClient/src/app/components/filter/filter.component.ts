import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Country, Flight } from 'src/app/_models/flight.model';
import { FlightService } from 'src/app/_services/flight.service';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.less']
})
export class FilterComponent implements OnInit {

  countries!: Country[];
  flights!: Flight[];
  constructor(
    private flightServer: FlightService,
    private fb: FormBuilder,
  ) { }

  form = this.fb.group({
    destination: this.fb.control(null),
    departureDate: this.fb.control(null),
    returnDate: this.fb.control(null),
  })

  ngOnInit(): void {
    this.flightServer.getAllCountries().subscribe((x) =>
      this.countries = x)
    this.flightServer.getAllFlights().subscribe((x) =>
      this.flights = x)
  }

  filterFlights() {
    debugger
    this.flightServer.filterFlights(
      this.form.controls.destination.value,
      this.form.controls.departureDate.value,
      this.form.controls.returnDate.value).subscribe((x) =>{ this.flights = x
      this.getAllFlights()})
  }

  getAllFlights() { return this.flights; }
}
