// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

(function () {
    'use strict';
    function findBiggest(a, b, c, d, e) {
        var biggestNumber = a;
        if (a < b) {
            biggestNumber = b;
        }
        if (biggestNumber < c) {
            biggestNumber = c;
        }
        if (biggestNumber < d) {
            biggestNumber = d;
        }
        if (biggestNumber < e) {
            biggestNumber = e;
        }

        return biggestNumber;
    }

    console.log('Result: ' + findBiggest(5, 2, 2, 4, 1));
    console.log('Result: ' + findBiggest(-2, -22, 1, 0, 0));
    console.log('Result: ' + findBiggest(-2, 4, 3, 2, 0));
    console.log('Result: ' + findBiggest(0, -2.5, 0, 5, 5));
    console.log('Result: ' + findBiggest(-3, -0.5, -1.1, -2, -0.1));
})();