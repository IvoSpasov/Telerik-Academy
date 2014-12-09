// 04 Write a function that checks if a given object contains a given property.

function hasPropery(object, property) {
    if (typeof(object) !== 'object') {
        return false;
    }

    var objProperty;

    for (objProperty in object) {
        if (objProperty === property) {
            return true;
        }
    }

    return false;
}

var hasProp;
var person = {
    firstName: 'John',
    lastName: 'Smith',
    toString: function fullName() {
        return this.firstName + ' ' + this.lastName;
    }
};

hasProp = hasPropery(person, 'firstName');
console.log('Does the person have a property "firstName": ' + hasProp);
hasProp = hasPropery(person, 'middleName');
console.log('Does the person have a property "middleName": ' + hasProp);