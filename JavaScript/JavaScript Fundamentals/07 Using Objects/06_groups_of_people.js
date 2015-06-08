// Write a function that groups an array of people by age, first or last name.
// The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)

(function () {
    'use strict';
    var people,
        groupedByAge,
        age;

    function Person(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    Person.prototype.toString = function () {
        return this.firstName + ' ' + this.lastName + ' at ' + this.age;
    };

    function groupPeople(people, groupBy) {
        var i,
            person,
            group,
            groupedPeople = {};

        for (i in people) {
            person = people[i];
            group = person[groupBy];
            if (!groupedPeople[group]) {
                groupedPeople[group] = [];
            }

            groupedPeople[group].push(person);
        }

        return groupedPeople;
    }

    people = [
        new Person('Gosho', 'Petrov', 23),
        new Person('Ivan', 'Topalov', 25),
        new Person('John', 'Smith', 53),
        new Person('Monika', 'Georgieva', 25),
        new Person('Antonia', 'Arsova', 28),
        new Person('Valdi', 'Petrov', 25)
    ];

    groupedByAge = groupPeople(people, 'age');

    for (age in groupedByAge) {
        console.log('People aged at ' + age + ': ' + groupedByAge[age].toString());
    }
})();