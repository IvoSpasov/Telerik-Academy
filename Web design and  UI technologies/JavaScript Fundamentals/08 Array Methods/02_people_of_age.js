// Write a function that checks if an array of person contains only people of age (with age 18 or greater)
// Use only array methods and no regular loops (for, while)

(function () {
    'use strict';
    function Person(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    var people = [
        new Person('Gosho', 'Petrov', 23),
        new Person('Ivan', 'Topalov', 12),
        new Person('John', 'Smith', 53),
        new Person('Monika', 'Georgieva', 10),
        new Person('Antonia', 'Arsova', 28)
    ],
        result;

    result = people.every(function (item) {
        return item.age >= 18;
    });
    console.log('Are all people above 18: ' + result);
})();