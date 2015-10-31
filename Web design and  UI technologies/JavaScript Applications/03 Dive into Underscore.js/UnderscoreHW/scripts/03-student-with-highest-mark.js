(function () {
    'use strict';

    var Student = (function () {
        function Student(firstName, lastName, age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.marks = [];
        }

        Student.prototype.addMark = function (mark) {
            this.marks.push(mark);
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

    // generate 10 random marks to each student
    _.each(students, function (currentStudent) {
        var marksCount = 10,
            mark,
            i;
        for (i = 0; i < marksCount; i += 1) {
            //random mark from 2 to 6
            mark = Math.random() * 4 + 2;
            currentStudent.addMark(mark)
        }
    });

    // return new array with calculated avrage mark
    var studentsWithOverallScore = _.map(students, function (currentStudent) {
        var marksSum = 0,
            averageScore;
        _.each(currentStudent.marks, function (currentMark) {
            marksSum += currentMark;
        });

        averageScore = (marksSum / currentStudent.marks.length).toFixed(2);

        return {
            firstName: currentStudent.firstName,
            lastName: currentStudent.lastName,
            age: currentStudent.age,
            averageScore: averageScore,
            info: currentStudent.toString() + ' with average score -> ' + averageScore
        }
    });

    console.log('------ All students ->')
    _.each(studentsWithOverallScore, function (currentStudent) {
        console.log(currentStudent.info);
    });

    // find the student with highest average score
    var sortedStudents = _.sortBy(studentsWithOverallScore, function (currentStudent) {
        return currentStudent.averageScore;
    });

    var bestStudent = _.last(sortedStudents);
        
    console.log('------ The student with the highest average score is:');
    console.log(bestStudent.info);

}());