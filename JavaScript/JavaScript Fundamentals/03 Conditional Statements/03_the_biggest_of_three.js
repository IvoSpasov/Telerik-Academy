// Write a script that finds the biggest of three numbers.
// Use nested if statements.

(function () {
    'use strict';
    function findBiggest(a, b, c) {
        if (a >= b) {
            if (a > c) {
                return a;
            }
            else {
                return c;
            }
        }
        if (b > a) {
            if (b > c) {
                return b;
            }
            else {
                return c;
            }
        }
    }

    console.log('Result: ' + findBiggest(5, 2, 2));
    console.log('Result: ' + findBiggest(-2, -2, 1));
    console.log('Result: ' + findBiggest(-2, 4, 3));
    console.log('Result: ' + findBiggest(0, -2.5, 5));
    console.log('Result: ' + findBiggest(-0.1, -0.5, -1.1));
})();