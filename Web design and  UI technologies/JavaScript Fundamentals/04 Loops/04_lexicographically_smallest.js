// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

(function (){
    'use strict';
    var smallestProperty = 'z',
        biggestProperty = 'a',
        objects = [document, window, navigator],
        i,
        property;

    for (i = 0; i < objects.length; i += 1) {
        for (property in objects[i]) {
            if (property.toLowerCase() < smallestProperty) {
                smallestProperty = property;
            }
            if (property.toLowerCase() > biggestProperty) {
                biggestProperty = property;
            }
        }

        console.log('The lexicographically smallest property in ' + objects[i] + ' is: ' + smallestProperty);
        console.log('The lexicographically biggest property in ' + objects[i] + ' is: ' + biggestProperty);
        smallestProperty = 'z';
        biggestProperty = 'a';
    }
})();