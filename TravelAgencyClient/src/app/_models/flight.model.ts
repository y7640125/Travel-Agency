import { User } from "./user.model";

export class Airline {
    constructor(
        public airlineId:number,
        public airlineName: string
    ) { }
}

export class Country {
    constructor(
        public countryId:number,
        public countryName: string
    ) { }
}

export class Flight {
    constructor(
        public Id: number,
        public airlineId: number,
        public airline:Airline,
        public countryId: number,
        public country:Country,
        public image?: string,
        public price?:number,
        public departureDate?: Date,
        public returnDate?: Date,
        public numSeats?: number,
        public numPassengers?:number,
        public pussengers?:User[],
        public update?: string
        
    ) { }
}