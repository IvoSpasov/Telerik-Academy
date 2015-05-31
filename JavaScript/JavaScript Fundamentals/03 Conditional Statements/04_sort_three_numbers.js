// Sort 3 real values in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

(function () {
    'use strict';
    function sortDescending(a, b, c) {
        var previousValue;
        if (a < b) {
            previousValue = a;
            a = b;
            b = previousValue;
            if (a < c) {
                previousValue = a;
                a = c;
                c = previousValue;
            }
        }
        if (b < c) {
            previousValue = b;
            b = c;
            c = previousValue;
            if (a < b) {
                previousValue = a;
                a = b;
                b = previousValue;
            }
        }

        printNumbers(a, b, c);
    }

    function printNumbers(a, b, c) {
        console.log('Sorted descending: ' + a + ' ' + b + ' ' + c);
    }

    sortDescending(5, 1, 2);
    sortDescending(-2, -2, 1);
    sortDescending(-2, 4, 3);
    sortDescending(0, -2.5, 5);
    sortDescending(-1.1, -0.5, -0.1);
    sortDescending(10, 20, 30);
    sortDescending(1, 1, 1);
})();