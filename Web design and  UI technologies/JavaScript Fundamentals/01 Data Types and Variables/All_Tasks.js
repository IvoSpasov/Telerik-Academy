(function () {
    'use strict';

    // Task 1
    // Assign all the possible JavaScript literals to different variables.

    var number = 5,
        floatingNumber = 53.15,
        string = 'Hello',
        bool = true,
        objectVariable = [5, 6, 7],
        notANumber = NaN,
        func = function sumFunc() {
            var sum = 5 + 6;
        };

    // Task 2
    // Create a string variable with quoted text in it. For example: 'How you doin'?', Joey said.

    var greeting = '"How you doin\'?", Joey said.';
    console.log(greeting);

    // Task 3
    // Try typeof on all variables you created.

    console.log(number + ' is from type ' + typeof number);
    console.log(floatingNumber + ' is from type ' + typeof floatingNumber);
    console.log(string + ' is from type ' + typeof string);
    console.log(bool + ' is from type ' + typeof (bool));
    console.log(objectVariable + ' is from type ' + typeof objectVariable);
    console.log(notANumber + ' is from type ' + typeof notANumber);
    console.log(func.name + ' is from type ' + typeof func);

    // Task 4
    // Create null, undefined variables and try typeof on them.

    var empty = null,
        notExisting = undefined;
    console.log(empty + ' is from type ' + typeof empty);
    console.log(notExisting + ' is from type ' + typeof notExisting);
})();


