module Malls {
    export class Person implements IPerson {
        constructor(public firstName: string, public lastName: string, public sex: Sex, public age?: number) {
        }

        toString(): string {
            var age = this.age || 'not available';
            var sex = this.sex === 0 ? 'male' : 'female';
            var result = 'Person info:\n' + this.firstName + ' ' + this.lastName + '\nage: ' + age + '\nsex: ' + sex;
            return result;
        }
    }
} 