export class Message {
    constructor(
        public name: string,
        public email: string,
        public subject: string,
        public message1: string,
        public answer?:string
    ) { }
}