(function () {
    'use strict';
    var Person = function () {
        function Person(firstName, lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        return Person;
    }();

    var people = [
        new Person('Linda', 'Nash'),
        new Person('Jeremy', 'Francis'),
        new Person('Margaert', 'Howell'),
        new Person('Guadalupe', 'Oliver'),
        new Person('Marilyn', 'Parsons'),
        new Person('Bernard', 'Barnett'),
        new Person('Tammy', 'Howell'),
        new Person('Elsie', 'Stanley'),
        new Person('Alexandra', 'Larson'),
        new Person('Linda', 'McCartney'),
        new Person('Elsie', 'Larson'),
        new Person('William', 'Howell'),
        new Person('Jeremy', 'Clarkson')
    ];

    var groupedByFirstName = _.groupBy(people, function (currentPerson) {
        return currentPerson.firstName;
    });

    var sortedByFirstNameRepetition = _.sortBy(groupedByFirstName, function (currentPerson) {
        return currentPerson.length;
    });

    var mostCommonSetOfFirstNames = _.last(sortedByFirstNameRepetition);
    var mostCommonFirstName = mostCommonSetOfFirstNames[0].firstName;
    console.log('The most common first name is: ' + mostCommonFirstName);

    var groupedByLastName = _.groupBy(people, function (currentPerson) {
        return currentPerson.lastName;
    });

    var sortedByLastNameRepetition = _.sortBy(groupedByLastName, function (currentPerson) {
        return currentPerson.length;
    });

    var mostCommonSetOfLastNames = _.last(sortedByLastNameRepetition);
    var mostCommonLastName = mostCommonSetOfLastNames[0].lastName;
    console.log('The most common last name is: ' + mostCommonLastName);
}());