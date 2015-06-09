// Write a function for creating persons.
// Each person must have firstname, lastname, age and gender (true is female, false is male)
// Generate an array with ten person with different names, ages and genders

(function () {
    'use strict';
    if (!Array.prototype.fill) {
        Array.prototype.fill = function (callback) {
            var i, len = this.length;
            for (i = 0; i < len; i += 1) {
                this[i] = arguments[0];
            }
            return this;
        };
    }

    function makePerson(firstName, lastName, age, isFemale) {
        return {
            firstName: firstName,
            lastName: lastName,
            age: age,
            isFemale: isFemale,
            toString: function () {
                return this.firstName + ' ' + this.lastName
                    + ' at ' + this.age + ', ' + (this.isFemale ? 'female' : 'male');
            }
        };
    }

    function randomGender() {
        if (Math.random() <= 0.5) {
            return true;
        }
        return false;
    }

    var people = [],
        count = 10;

    people.length = count;
    people.fill(1);
    people = people.map(function (item, index) {
        return makePerson('FirstName' + index, 'LastName' + index, 20 + index, randomGender());
    }).forEach(function (item) {
        console.log(item.toString());
    });
})();