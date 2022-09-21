export class User {
    constructor(
        public Id: number,
        public roleId: number,
        public name: string,
        public password:string,
        public email: string,
        public advertisements:boolean
    ) { }
}