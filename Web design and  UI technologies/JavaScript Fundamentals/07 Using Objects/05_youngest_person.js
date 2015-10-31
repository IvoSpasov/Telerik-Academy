// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

(function () {
    'use strict';
    function Person(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    Person.prototype.toString = function () {
        return this.firstName + ' ' + this.lastName + ' at ' + this.age;
    };

    function isYounger(younger, older) {
        if (younger.age < older.age) {
            return true;
        }

        return false;
    }

    function findYoungestPerson(people) {
        var i,
            length,
            youngest = people[0];
        for (i = 1, length = people.length; i < length; i += 1) {
            if (isYounger(people[i], youngest)) {
                youngest = people[i];
            }
        }

        return youngest;
    }

    var people = [
        new Person('Gosho', 'Petrov', 23),
        new Person('Ivan', 'Topalov', 25),
        new Person('John', 'Smith', 53),
        new Person('Monika', 'Georgieva', 10),
        new Person('Antonia', 'Arsova', 28)
    ];

    console.log(findYoungestPerson(people).toString() + ' is the youngest.');
})();