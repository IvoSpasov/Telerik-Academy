// Write a function that calculates the average age of all females, extracted from an array of persons
// Use Array#filter
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
        new Person('Gosho', 'Petrov', 23, false),
        new Person('Ivan', 'Topalov', 12, false),
        new Person('John', 'Smith', 53, false),
        new Person('Monika', 'Georgieva', 15, true),
        new Person('Antonia', 'Arsova', 10, true),
        new Person('Maria', 'Aleksandorva', 35, true)
    ],
        allFemales,
        sumOfFemaleAges,
        averageFemaleAge;

    allFemales = people.filter(function (person) {
        return person.isFemale;
    });
    sumOfFemaleAges = allFemales.reduce(function (sum, person, index, arr) {
        return (sum + person.age);
    }, 0);
    averageFemaleAge = sumOfFemaleAges / allFemales.length;
    console.log('Average female age is: ' + averageFemaleAge);
})();