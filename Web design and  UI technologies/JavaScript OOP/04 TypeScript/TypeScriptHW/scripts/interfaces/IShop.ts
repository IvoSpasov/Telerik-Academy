interface IShop {
    name: string;
    employees: IEmployee[];
    addEmployee(empl: IEmployee): void;
    removeEmployee(empl: IEmployee): IEmployee;

    toString(): string;
}