module Malls {
    export class Employee extends Person implements IEmployee, IPerson {
        constructor(public firstName: string, public lastName: string, public sex: Sex, public salary: number, public age?: number) {
            super(firstName, lastName, sex, age)
        }

        toString(): string {
            var result = super.toString() + '\nsalary: ' + this.salary;
            return result;
        }
    }
}
