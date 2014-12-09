//01 Write a function that groups an array of persons by age, first or last name. The function must return an associative array, 
// with keys - the groups, and values -arrays with persons in this groups. Use function overloading (i.e. just one function)

function createPerson(fName, lName, age) {
    return {
        firstName: fName,
        lastName: lName,
        age: age,
        fullName: function getFullName() {
            return this.firstName + ' ' + this.lastName + ' aged ' + age;
        }
    };
}

var people = [
    createPerson('Gosho', 'Petrov', 53),
    createPerson('Ivan', 'Topalov', 25),
    createPerson('John', 'Smith', 53),
    createPerson('Monika', 'Georgieva', 10),
    createPerson('Antonia', 'Arsova', 28),
    createPerson('Vladislav', 'Libarov', 25)
];

function group(persons, groupBy) {
    var groupedPersons = {};
    var i;
    var person;
    var group;

    for (i in persons) {
        person = persons[i];
        group = person[groupBy];

        if (!groupedPersons[group]) {
            groupedPersons[group] = []; //create key
        }

        groupedPersons[group].push(person); // add to key            
    }
    return groupedPersons;
}

var groupedByAge = group(people, 'age');
var i, j;
for (i in groupedByAge) {
    for (j = 0; j < groupedByAge[i].length; j += 1) {
        console.log(groupedByAge[i][j].fullName());
    }

}
