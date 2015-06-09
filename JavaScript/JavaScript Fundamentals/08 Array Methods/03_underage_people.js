// Write a function that prints all underaged persons of an array of person
// Use Array#filter and Array#forEach
// Use only array methods and no regular loops (for, while)

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

    var people = [
        new Person('Gosho', 'Petrov', 23),
        new Person('Ivan', 'Topalov', 12),
        new Person('John', 'Smith', 53),
        new Person('Monika', 'Georgieva', 10),
        new Person('Antonia', 'Arsova', 28)
    ];

    people.filter(function (item) {
        return item.age < 18;
    }).forEach(function (item) {
        console.log(item.toString());
    });
})();