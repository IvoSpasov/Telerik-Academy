// Write a function that makes a deep copy of an object.
// The function should work for both primitive and reference types.

(function () {
    'use strict';
    var numbers,
        numbersCopy,
        person,
        personCopy,
        number,
        numberCopy;

    function createDeepCopy(object) {
        var copy,
            element;

        if (Array.isArray(object)) {
            copy = [];
        }
        else if (typeof object === 'object') {
            copy = {};
        }
        else {
            copy = object;
        }

        for (element in object) {
            copy[element] = object[element];
        }

        return copy;
    }

    numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
    numbersCopy = createDeepCopy(numbers);
    numbersCopy[4] = 5555;
    console.log('numbers -> ' + numbers);
    console.log('numbersCopy after modifying -> ' + numbersCopy);
    console.log('numbers -> ' + numbers);
    console.log('');

    person = {
        firstName: 'John',
        lastName: 'Smith',
        toString: function fullName() {
            return this.firstName + ' ' + this.lastName;
        }
    };
    personCopy = createDeepCopy(person);
    personCopy.firstName = 'James';
    console.log('person -> ' + person);
    console.log('personCopy after modifying -> ' + personCopy);
    console.log('person -> ' + person);
    console.log('');

    number = 5;
    numberCopy = createDeepCopy(number);
    numberCopy = 10;
    console.log('number -> ' + number);
    console.log('numberCopy after modifying -> ' + numberCopy);
    console.log('number -> ' + number);
})();