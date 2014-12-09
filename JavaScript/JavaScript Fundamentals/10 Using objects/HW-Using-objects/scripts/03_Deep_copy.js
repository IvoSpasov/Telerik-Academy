// 03 Write a function that makes a deep copy of an object. 
// The function should work for both primitive and reference types.

function deepCopy(object) {
    var objectCopy;
    var element;

    if (Array.isArray(object)) {
        objectCopy = [];
    }
    else {
        switch (typeof(object)) {
            case 'object': objectCopy = {}; break;
            default: objectCopy = object; break; // if it is not an object or array just copy the value (for primitive types)
                // there is a possibility that I'm missing a case
        }
    }


    for (element in object) {
        objectCopy[element] = object[element];
    }

    return objectCopy;
}

var numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
var numbersCopy = deepCopy(numbers);
numbersCopy[4] = 5555;
console.log('numbers array -> ' + numbers);
console.log('numbersCopy array after modifying -> ' + numbersCopy);
console.log('numbers array again -> ' + numbers);
console.log('');

var person = {
    firstName: 'John',
    lastName: 'Smith',
    toString: function fullName() {
        return this.firstName + ' ' + this.lastName;
    }
};

var personCopy = deepCopy(person);
console.log('person -> ' + person.toString());
personCopy.firstName = 'James';
console.log('personCopy after modyfing it -> ' + personCopy.toString());
console.log('person after modifying personCopy -> ' + person.toString());
console.log('');

var num = 5;
var numCopy = deepCopy(num);
console.log('numCopy -> ' + numCopy);
numCopy = 10;
console.log('modifying numCopy to ten -> ' + numCopy);
console.log('num -> ' + num);

console.log(typeof (Date));