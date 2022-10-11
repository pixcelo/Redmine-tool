export class Greeter {
    greeting: string

    constructor(greeting: string) {
        this.greeting = greeting
    }

    greet(name: string) {
        console.log(`${this.greeting} ${name}`)
    }
}
