interface IPerson {
    firstName: string;
    lastName: string;
    age?: number;
    sex: Sex;

    toString(): string;
} 