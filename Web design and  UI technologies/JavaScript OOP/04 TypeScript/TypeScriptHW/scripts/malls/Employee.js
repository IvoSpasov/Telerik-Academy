var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Malls;
(function (Malls) {
    var Employee = (function (_super) {
        __extends(Employee, _super);
        function Employee(firstName, lastName, sex, salary, age) {
            _super.call(this, firstName, lastName, sex, age);
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.salary = salary;
            this.age = age;
        }
        Employee.prototype.toString = function () {
            var result = _super.prototype.toString.call(this) + '\nsalary: ' + this.salary;
            return result;
        };
        return Employee;
    })(Malls.Person);
    Malls.Employee = Employee;
})(Malls || (Malls = {}));
//# sourceMappingURL=Employee.js.map
