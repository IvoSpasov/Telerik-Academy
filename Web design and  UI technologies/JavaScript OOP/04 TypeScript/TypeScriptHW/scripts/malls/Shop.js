var Malls;
(function (Malls) {
    var Shop = (function () {
        function Shop(name) {
            this.name = name;
            this.employees = new Array();
        }
        Shop.prototype.addEmployee = function (empl) {
            this.employees.push(empl);
        };

        Shop.prototype.removeEmployee = function (empl) {
            var indexOfEmpoyee = this.employees.indexOf(empl);
            if (indexOfEmpoyee < 0) {
                throw new Error('Employee to be removed is not found.');
            }

            var employeeToRemove = this.employees[indexOfEmpoyee];
            this.employees[indexOfEmpoyee] = this.employees[this.employees.length - 1];
            this.employees.pop;

            return employeeToRemove;
        };

        Shop.prototype.countEmployees = function () {
            var numberOfEmployees = this.employees.length;
            return numberOfEmployees;
        };

        Shop.prototype.toString = function () {
            var result = 'Shop info:\n' + 'name: ' + this.name + '\nnumber of employees: ' + this.countEmployees();
            return result;
        };

        Shop.greetCustomers = function () {
            console.log('Hello customers.');
        };
        return Shop;
    })();
    Malls.Shop = Shop;
})(Malls || (Malls = {}));
//# sourceMappingURL=Shop.js.map
