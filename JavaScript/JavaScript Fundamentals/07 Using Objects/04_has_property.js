// Write a function that checks if a given object contains a given property.

(function () {
    'use strict';
    var john;

    function hasProperty(object, propertyName) {
        if (typeof object !== 'object') {
            return false;
        }

        if (object[propertyName] !== undefined) {
            return true;
        }

        return false;

//        var objProperty;
//        for (objProperty in object) {
//            if (objProperty === propertyName) {
//                return true;
//            }
//        }
    }

    john = {
        firstName: 'John',
        lastName: 'Smith'
    };

    console.log('Does the person have a property "firstName": ' + hasProperty(john, 'firstName'));
    console.log('Does the person have a property "middleName": ' + hasProperty(john, 'middleName'));
})();