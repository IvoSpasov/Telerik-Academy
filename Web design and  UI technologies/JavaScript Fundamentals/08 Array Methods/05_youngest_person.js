// Write a function that finds the youngest male person in a given array of people and prints his full name
// Use only array methods and no regular loops (for, while)
// Use Array#find

(function () {
    'use strict';
    if (!Array.prototype.find) {
        Array.prototype.find = function (callback) {
            var i, len = this.length;
            for (i = 0; i < len; i += 1) {
                if (callback(this[i], i, this)) {
                    return this[i];
                }
            }
        };
    }

    function Person(firstName, lastName, age, isFemale) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.isFemale = isFemale;
    }

    Person.prototype.toString = function () {
        return this.firstName + ' ' + this.lastName;
    };

    var people = [
            new Person('Gosho', 'Petrov', 23, false),
            new Person('Ivan', 'Topalov', 12, false),
            new Person('John', 'Smith', 53, false),
            new Person('Monika', 'Georgieva', 15, true),
            new Person('Antonia', 'Arsova', 10, true),
            new Person('Maria', 'Aleksandorva', 35, true)
        ],
        youngest;

    youngest = people.filter(function (person) {
        return !person.isFemale;
    }).sort(function (x, y) {
        return x.age - y.age;
    }).find(function (person, index) {
        return index === 0;
    });

    console.log('The youngest male is: ' + youngest.toString());
})();