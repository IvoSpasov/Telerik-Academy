// Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.

(function () {
    'use strict';
    var numbers = [],
        i;

    for (i = 0; i < 20; i += 1) {
        numbers[i] = i * 5;
    }

    console.log(numbers.join(', '));
})();