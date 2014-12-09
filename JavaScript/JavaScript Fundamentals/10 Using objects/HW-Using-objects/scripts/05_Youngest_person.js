// 05 Write a function that finds the youngest person in a given array of persons and prints his/hers full name.
// Each person have properties firstname, lastnameand age

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
    createPerson('Gosho', 'Petrov', 23),
    createPerson('Ivan', 'Topalov', 25),
    createPerson('John', 'Smith', 53),
    createPerson('Monika', 'Georgieva', 10),
    createPerson('Antonia', 'Arsova', 28)
];

function getYoungestPerson(arrayOfObjects) {
    var minAge = Number.MAX_VALUE;
    var indexOfPerson;
    var i;
    for (i in arrayOfObjects) {
        if (minAge > arrayOfObjects[i].age) {
            minAge = arrayOfObjects[i].age;
            indexOfPerson = i;
        }        
    }

    return arrayOfObjects[indexOfPerson].fullName();
}

var youngestPerson = getYoungestPerson(people);
console.log('The youngest person is ' + youngestPerson + '.');