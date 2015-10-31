(function () {
    'use strict';

    var Student = (function () {
        function Student(firstName, lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        Student.prototype.toString = function () {
            return this.firstName + ' ' + this.lastName;
        }

        return Student;
    }());

    var students = [
        new Student('Linda', 'Nash'),
        new Student('Jeremy', 'Francis'),
        new Student('Guadalupe', 'Oliver'),
        new Student('Marilyn', 'Parsons'),
        new Student('Bernard', 'Barnett'),
        new Student('Tammy', 'Howell'),
        new Student('Elsie', 'Stanley')
    ];

    var studentsWithFirstNameBeforeLast = _.filter(students, function (currentStudent) {
        return currentStudent.firstName < currentStudent.lastName;
    });

    var sortedStudents = _.sortBy(studentsWithFirstNameBeforeLast, function (currentStudent) {
        return currentStudent.toString();
    }).reverse();

    console.log('------ The students with their first name alphabetically before they last (and sorted descendingly) are:')
    _.each(sortedStudents, function (currentStudent) {
        console.log(currentStudent.toString());
    })
}());