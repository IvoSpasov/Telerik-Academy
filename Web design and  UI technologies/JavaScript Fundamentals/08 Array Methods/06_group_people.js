// Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
// Use Array#reduce
// Use only array methods and no regular loops (for, while)

(function () {
    'use strict';
    function Person(firstName, lastName, age, isFemale) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.isFemale = isFemale;
    }

    var people = [
        new Person('Ivo', 'Petrov', 23, false),
        new Person('Ivan', 'Topalov', 12, false),
        new Person('John', 'Smith', 53, false),
        new Person('Monika', 'Georgieva', 15, true),
        new Person('Martina', 'Arsova', 10, true),
        new Person('Maria', 'Aleksandorva', 35, true)
    ],
        result;

    result = people.reduce(function (obj, person, index, arr) {
        var firstLetter = person.firstName[0].toLowerCase();
        if (!obj[firstLetter]) {
            obj[firstLetter] = [];
        }
        obj[firstLetter].push(person);

        return obj;
    }, {});

    console.log(result);
})();