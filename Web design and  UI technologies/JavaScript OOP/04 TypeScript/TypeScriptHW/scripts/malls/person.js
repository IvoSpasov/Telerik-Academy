var Malls;
(function (Malls) {
    var Person = (function () {
        function Person(firstName, lastName, sex, age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.age = age;
        }
        Person.prototype.toString = function () {
            var age = this.age || 'not available';
            var sex = this.sex === 0 ? 'male' : 'female';
            var result = 'Person info:\n' + this.firstName + ' ' + this.lastName + '\nage: ' + age + '\nsex: ' + sex;
            return result;
        };
        return Person;
    })();
    Malls.Person = Person;
})(Malls || (Malls = {}));
//# sourceMappingURL=Person.js.map
