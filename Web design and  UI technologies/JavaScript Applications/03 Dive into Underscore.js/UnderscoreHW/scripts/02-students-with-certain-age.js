(function () {
    'use strict';

    var Student = (function () {
        function Student(firstName, lastName, age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        Student.prototype.toString = function () {
            return this.firstName + ' ' + this.lastName + ' aged ' + this.age;
        }

        return Student;
    }());

    var students = [
        new Student('Linda', 'Nash', 31),
        new Student('Jeremy', 'Francis', 24),
        new Student('Guadalupe', 'Oliver', 15),
        new Student('Marilyn', 'Parsons', 18),
        new Student('Bernard', 'Barnett', 22),
        new Student('Tammy', 'Howell', 32),
        new Student('Elsie', 'Stanley', 29)
    ];

    var studentsWithCertainAge = _.filter(students, function (currentStudent) {
        if (18 <= currentStudent.age && currentStudent.age <= 24) {
            return true;
        }

        return false;
    });

    console.log('------ The students between age 18 and 24 are:');
    _.each(studentsWithCertainAge, function (currentStudnet) {
        console.log(currentStudnet.toString());
    })
}());