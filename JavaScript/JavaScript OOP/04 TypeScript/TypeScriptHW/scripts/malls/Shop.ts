module Malls {
    export class Shop implements IShop {

        employees: IEmployee[];

        constructor(public name: string) {
            this.employees = new Array<Employee>();
        }

        addEmployee(empl: IEmployee): void {
            this.employees.push(empl);
        }

        removeEmployee(empl: IEmployee): IEmployee {
            var indexOfEmpoyee = this.employees.indexOf(empl);
            if (indexOfEmpoyee < 0) {
                throw new Error('Employee to be removed is not found.');
            }

            var employeeToRemove = this.employees[indexOfEmpoyee];
            this.employees[indexOfEmpoyee] = this.employees[this.employees.length - 1];
            this.employees.pop;

            return employeeToRemove;
        }

        countEmployees(): number {
            var numberOfEmployees = this.employees.length;
            return numberOfEmployees;
        }

        toString(): string {
            var result = 'Shop info:\n' + 'name: ' + this.name + '\nnumber of employees: ' + this.countEmployees();
            return result;
        }

        public static greetCustomers(): void {
            console.log('Hello customers.');
        }
    }
} 